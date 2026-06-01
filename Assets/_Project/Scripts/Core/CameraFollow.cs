using UnityEngine;

namespace BirdGame
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private BirdLauncher birdLauncher;
        [SerializeField] private Transform slingshotPivot;

        [Header("Settings")]
        [SerializeField] private float followSpeed = 3f;
        [SerializeField] private float stopSpeedThreshold = 0.1f;

        private new Camera camera;
        private Rigidbody2D birdRigidbody;
        private float baseY;
        private float offsetX;
        private bool isFollowing;
        private bool hasSettled;

        private void Awake()
        {
            camera = GetComponent<Camera>();
            baseY = transform.position.y;

            if (birdLauncher != null)
            {
                birdRigidbody = birdLauncher.GetComponent<Rigidbody2D>();
            }

            if (slingshotPivot != null)
            {
                offsetX = transform.position.x - slingshotPivot.position.x;
            }
        }

        private void LateUpdate()
        {
            if (birdLauncher == null || slingshotPivot == null) return;

            if (!hasSettled && birdLauncher.CurrentState == BirdState.Launched)
            {
                isFollowing = true;
            }

            if (isFollowing)
            {
                if (birdRigidbody.IsSleeping() || birdRigidbody.linearVelocity.magnitude <= stopSpeedThreshold)
                {
                    hasSettled = true;
                    isFollowing = false;
                    return;
                }

                Vector3 targetPosition = transform.position;
                targetPosition.x = birdLauncher.transform.position.x + offsetX;
                targetPosition.y = baseY;
                transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            }
            else if (!hasSettled)
            {
                Vector3 targetPosition = transform.position;
                targetPosition.x = slingshotPivot.position.x + offsetX;
                targetPosition.y = baseY;
                transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
            }
        }
    }
}
