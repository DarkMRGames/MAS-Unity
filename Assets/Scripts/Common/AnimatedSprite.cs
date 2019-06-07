using UnityEngine;

namespace Assets.Scripts.Common
{
    public class AnimatedSprite : MonoBehaviour
    {
        public int framesPerSecond;
        public Sprite[] frames;
        public bool returnToIdleFrame;

        private Sprite _idleSprite = null;
        private bool _play;

        public bool PlayOnStart;

        public virtual bool Play {
            get {
                return _play;
            }
            set {
                _play = value;

                if(!_play && returnToIdleFrame)
                    GetComponent<SpriteRenderer>().sprite = _idleSprite;
            }
        }

        protected virtual void Start()
        {
            _idleSprite = GetComponent<SpriteRenderer>().sprite;
            Play = PlayOnStart;
        }

        protected void Update()
        {
            if (!Play)
                return;
            
            int position = (int)(Time.time * framesPerSecond) % frames.Length;
            GetComponent<SpriteRenderer>().sprite = frames[position];
            OnFrameChange(position);

            if (position + 1 == frames.Length)
                OnLoopEnded();
        }

        public virtual void OnFrameChange(int positionFrame) { }
        public virtual void OnLoopEnded() { }
    }
}
