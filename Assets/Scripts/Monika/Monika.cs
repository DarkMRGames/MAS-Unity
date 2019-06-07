using Assets.Scripts.Api;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Monika
{
    public class Monika : MonoBehaviour, IMonika
    {
        private MonikaPose _actualPose;
        private IMonikaHair _actualHair;
        private IMonikaClothing _actualClothing;

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

        public IMonikaHair Hair
        {
            set
            {
                hair_back.GetComponent<SpriteRenderer>().sprite = value.Back;
                hair_front.GetComponent<SpriteRenderer>().sprite = value.Front;

                ribbon.SetActive(value.HasRibbon);
                _actualHair = value;
            }
        }

        public string HairName
        {
            set
            {
                Hair = MonikaSprites.Hairs[value];
            }
        }

        public IMonikaClothing Clothing
        {
            set
            {
                if (_actualPose.IsLeaning)
                {
                    body.GetComponent<SpriteRenderer>().sprite = value.BodyLeaning;
                    arms.GetComponent<SpriteRenderer>().sprite = _actualPose.GetArms(value);
                }
                else
                {
                    body.GetComponent<SpriteRenderer>().sprite = value.Body;
                    arms.GetComponent<SpriteRenderer>().sprite = _actualPose.GetArms(value);
                }

                _actualClothing = value;
            }
        }

        public string ClothingName
        {
            set
            {
                Clothing = MonikaSprites.Clothes[value];
            }
        }
               
        public MonikaPose Pose
        {
            set
            {
                bool isActualyLeaning = _actualPose.IsLeaning;
                _actualPose = value;

                eyebrows.GetComponent<SpriteRenderer>().sprite = value.Eyebrows;
                eyes.GetComponent<SpriteRenderer>().sprite = value.Eyes;
                mouth.GetComponent<SpriteRenderer>().sprite = value.Mouth;

                if (value.IsLeaning)
                {
                    face.MoveTo(faceLeaningPosition);
                    Hair = _actualHair;
                    Clothing = _actualClothing;
                }
                else if (isActualyLeaning)
                {
                    face.MoveTo(facePosition);
                    Hair = _actualHair;
                    Clothing = _actualClothing;
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
            HairName = "def";
            ClothingName = "def";
        }

        /*private void OnDestroy()
        {
            Global.Monika = null;
        }*/
    }
}
