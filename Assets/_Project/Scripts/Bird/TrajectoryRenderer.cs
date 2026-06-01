using UnityEngine;

namespace BirdGame
{
    /// <summary>
    /// Draws a simple predicted projectile path for the bird launch.
    /// </summary>
    [RequireComponent(typeof(LineRenderer))]
    public class TrajectoryRenderer : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private LineRenderer lineRenderer;

        [Header("Settings")]
        [SerializeField] private int pointCount = 30;
        [SerializeField] private float timeStep = 0.1f;

        private void Awake()
        {
            if (lineRenderer == null)
            {
                lineRenderer = GetComponent<LineRenderer>();
            }

            lineRenderer.useWorldSpace = true;
            HideTrajectory();
        }

        public void ShowTrajectory(Vector2 startPosition, Vector2 initialVelocity, Vector2 gravity)
        {
            lineRenderer.positionCount = pointCount;

            for (int i = 0; i < pointCount; i++)
            {
                float time = i * timeStep;
                Vector2 point = startPosition + initialVelocity * time + 0.5f * gravity * time * time;

                lineRenderer.SetPosition(i, new Vector3(point.x, point.y, 0f));
            }
        }

        public void HideTrajectory()
        {
            lineRenderer.positionCount = 0;
        }
    }
}
