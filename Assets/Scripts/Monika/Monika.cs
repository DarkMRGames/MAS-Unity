using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Monika
{
    public class Monika : MonoBehaviour, IMonika
    {
        private MonikaPose _actualPose;

        public GameObject
            hair_back, body, ribbon, hair_front, arms, face,
            eyebrows, eyes, nose, mouth;

        public Transform facePosition;
        public Transform faceLeaningPosition;

        public bool Talking {
            get
            {
                return mouth.GetComponent<AnimatedSprite>().Play;
            }
            set
            {
                mouth.GetComponent<AnimatedSprite>().Play = value;
            }
        }

        public bool IsLeaning
        {
            get
            {
                return _actualPose.IsLeaning;
            }
        }

        public int Affection { get; private set; }

        public MonikaPose Pose
        {
            set
            {
                _actualPose = value;
                eyebrows.GetComponent<SpriteRenderer>().sprite = value.Eyebrows;
                eyes.GetComponent<SpriteRenderer>().sprite = value.Eyes;
                mouth.GetComponent<SpriteRenderer>().sprite = value.Mouth;

                if (value.IsLeaning)
                {
                    face.transform.position = faceLeaningPosition.position;
                    face.transform.rotation = faceLeaningPosition.rotation;
                }
                else
                {
                    face.transform.position = facePosition.position;
                    face.transform.rotation = facePosition.rotation;
                }
            }
        }

        private void Awake()
        {
            Global.Monika = this;
        }

        private void Start()
        {
            Pose = "1eua";
        }

        /*private void OnDestroy()
        {
            Global.Monika = null;
        }*/
    }
}
