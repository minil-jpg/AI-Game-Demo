using UnityEngine;

namespace BirdGame
{
    public class BirdResetInput : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private BirdLauncher birdLauncher;
        [SerializeField] private CameraFollow cameraFollow;

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.R)) return;
            if (birdLauncher == null) return;

            birdLauncher.ResetToLaunchPoint();

            if (cameraFollow != null)
            {
                cameraFollow.OnBirdReset();
            }
        }
    }
}
