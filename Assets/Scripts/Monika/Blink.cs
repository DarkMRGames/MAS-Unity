using Assets.Scripts.Common;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Monika
{
     class Blink : AnimatedSprite
    {
        public float minIntervalSeconds = 2;
        public float maxIntervalSeconds = 5;

        private float _intervalSeconds;

        protected override void Start()
        {
            base.Start();
            _intervalSeconds = Random.Range(minIntervalSeconds, maxIntervalSeconds);
        }

        public override void OnLoopEnded()
        {
            if (Play)            
                StartCoroutine(WaitLooping());
        }

        IEnumerator WaitLooping()
        {
            Play = false;
            yield return new WaitForSeconds(_intervalSeconds);
            Play = true;
            _intervalSeconds = Random.Range(minIntervalSeconds, maxIntervalSeconds);            
        }
    }
}
