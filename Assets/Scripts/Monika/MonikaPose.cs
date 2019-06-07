using UnityEngine;

namespace Assets.Scripts.Monika
{
    public struct MonikaPose
    {
        private readonly string _pose, _eyes, _eyebrows, _mouth;

        public bool IsLeaning
        {
            get
            {
                return _pose == "5";
            }
        }

        public Sprite Eyebrows
        {
            get
            {
                return MonikaSprites.Eyebrows.GetSprite(_eyebrows);
            }
        }

        public Sprite Eyes
        {
            get
            {
                return MonikaSprites.Eyes.GetSprite(_eyes);
            }
        }

        public Sprite Mouth
        {
            get
            {
                return MonikaSprites.Mouth.GetSprite(_mouth);
            }
        }

        public MonikaPose(string poseCode)
        {
            _pose       = poseCode[0].ToString();
            _eyes       = poseCode[1].ToString();
            _eyebrows   = poseCode[2].ToString();
            _mouth      = poseCode[3].ToString();
        }

        public static implicit operator MonikaPose(string poseCode)
        {
            return new MonikaPose(poseCode);
        }
    }
}
