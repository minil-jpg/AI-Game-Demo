using UnityEngine;

namespace BirdGame
{
    public class BirdAutoReset : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private BirdLauncher birdLauncher;
        [SerializeField] private CameraFollow cameraFollow;

        [Header("Settings")]
        [SerializeField] private float resetDelay = 2f;

        private Rigidbody2D rb;
        private float timer;
        private bool isCounting;

        private void Awake()
        {
            if (birdLauncher != null)
            {
                rb = birdLauncher.GetComponent<Rigidbody2D>();
            }
        }

        private void Update()
        {
            if (birdLauncher == null || rb == null) return;

            if (birdLauncher.CurrentState != BirdState.Launched)
            {
                isCounting = false;
                timer = 0f;
                return;
            }

            if (rb.IsSleeping() && !isCounting)
            {
                isCounting = true;
                timer = 0f;
            }

            if (isCounting)
            {
                timer += Time.deltaTime;

                if (timer >= resetDelay)
                {
                    PerformReset();
                }
            }
        }

        private void PerformReset()
        {
            isCounting = false;
            timer = 0f;

            birdLauncher.ResetToLaunchPoint();

            if (cameraFollow != null)
            {
                cameraFollow.OnBirdReset();
            }
        }
    }
}
