using UnityEngine;

namespace BirdGame
{
    /// <summary>
    /// Handles mouse input for dragging the bird.
    /// Converts mouse position to world coordinates and notifies the BirdLauncher.
    /// </summary>
    public class BirdDragHandler : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private BirdLauncher launcher;
        [SerializeField] private TrajectoryRenderer trajectoryRenderer;

        private Camera mainCamera;

        private void Awake()
        {
            mainCamera = Camera.main;

            // Auto-assign launcher if not set in inspector
            if (launcher == null)
            {
                launcher = GetComponent<BirdLauncher>();
            }
        }

        private void OnMouseDown()
        {
            // Detection starts when player clicks on the bird's collider
        }

        private void OnMouseDrag()
        {
            if (launcher == null) return;

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10; // Distance from camera
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);

            launcher.ProcessDrag(worldPosition);

            if (trajectoryRenderer == null) return;

            Vector2 startPosition = transform.position;
            Vector2 launchVelocity = launcher.GetLaunchVelocityFromPosition(startPosition);

            trajectoryRenderer.ShowTrajectory(startPosition, launchVelocity, launcher.LaunchGravity);
        }

        private void OnMouseUp()
        {
            if (launcher == null) return;

            if (trajectoryRenderer != null)
            {
                trajectoryRenderer.HideTrajectory();
            }

            launcher.Launch();
        }
    }
}
