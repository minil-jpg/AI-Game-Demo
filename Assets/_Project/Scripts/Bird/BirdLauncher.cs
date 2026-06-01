using UnityEngine;

namespace BirdGame
{
    /// <summary>
    /// Handles the physics-based launching of the bird.
    /// Manages the bird's state and interacts with the Rigidbody2D.
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class BirdLauncher : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Transform launchPoint;
        [SerializeField] private Rigidbody2D rb;

        [Header("Settings")]
        [SerializeField] private float maxDragDistance = 2f;
        [SerializeField] private float launchForceMultiplier = 10f;

        [Header("Landing")]
        [SerializeField] private float airLinearDamping = 0f;
        [SerializeField] private float airAngularDamping = 0.2f;
        [SerializeField] private float groundLinearDamping = 2f;
        [SerializeField] private float groundAngularDamping = 5f;
        [SerializeField] private float sleepLinearSpeedThreshold = 0.05f;
        [SerializeField] private float sleepAngularSpeedThreshold = 5f;
        [SerializeField] private string groundTag = "Ground";
        [SerializeField] private float groundNormalThreshold = 0.5f;

        private BirdState currentState = BirdState.Idle;
        private bool isGrounded;

        public BirdState CurrentState => currentState;

        private void Awake()
        {
            // Auto-assign Rigidbody2D if not set in inspector
            if (rb == null)
            {
                rb = GetComponent<Rigidbody2D>();
            }

            SetupInitialState();
        }

        private void SetupInitialState()
        {
            currentState = BirdState.Idle;
            
            // Initial physics setup for kinematic bird
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.gravityScale = 0f;
            rb.linearVelocity = Vector2.zero;
            rb.angularVelocity = 0f;
            rb.linearDamping = airLinearDamping;
            rb.angularDamping = airAngularDamping;
        }

        /// <summary>
        /// Moves the bird to a position constrained within the drag radius.
        /// Called by the DragHandler.
        /// </summary>
        public void ProcessDrag(Vector3 worldPosition)
        {
            if (currentState == BirdState.Launched) return;

            currentState = BirdState.Dragging;

            Vector2 offset = worldPosition - launchPoint.position;
            
            // Constrain bird within max drag distance
            Vector2 constrainedOffset = Vector2.ClampMagnitude(offset, maxDragDistance);
            
            transform.position = (Vector2)launchPoint.position + constrainedOffset;
        }

        /// <summary>
        /// Launches the bird based on its current position relative to the launch point.
        /// Called by the DragHandler.
        /// </summary>
        public void Launch()
        {
            if (currentState != BirdState.Dragging) return;

            currentState = BirdState.Launched;
            isGrounded = false;

            // Enable physics
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.gravityScale = 1f;
            rb.linearDamping = airLinearDamping;
            rb.angularDamping = airAngularDamping;

            // Calculate force: vector from bird to launch point
            Vector2 forceDirection = (Vector2)launchPoint.position - (Vector2)transform.position;
            Vector2 launchForce = forceDirection * launchForceMultiplier;

            // Apply impulse force
            rb.AddForce(launchForce, ForceMode2D.Impulse);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            ApplyGroundDragIfNeeded(collision);
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            ApplyGroundDragIfNeeded(collision);
            SleepIfSettled();
        }

        private void ApplyGroundDragIfNeeded(Collision2D collision)
        {
            if (currentState != BirdState.Launched) return;
            if (!IsGroundCollision(collision)) return;

            isGrounded = true;
            rb.linearDamping = groundLinearDamping;
            rb.angularDamping = groundAngularDamping;
        }

        private void SleepIfSettled()
        {
            if (!isGrounded) return;

            bool linearVelocityIsLow = rb.linearVelocity.magnitude <= sleepLinearSpeedThreshold;
            bool angularVelocityIsLow = Mathf.Abs(rb.angularVelocity) <= sleepAngularSpeedThreshold;

            if (!linearVelocityIsLow || !angularVelocityIsLow) return;

            rb.linearVelocity = Vector2.zero;
            rb.angularVelocity = 0f;
            rb.Sleep();
        }

        private bool IsGroundCollision(Collision2D collision)
        {
            if (!collision.gameObject.CompareTag(groundTag)) return false;

            for (int i = 0; i < collision.contactCount; i++)
            {
                ContactPoint2D contact = collision.GetContact(i);

                if (Mathf.Abs(contact.normal.y) >= groundNormalThreshold)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
