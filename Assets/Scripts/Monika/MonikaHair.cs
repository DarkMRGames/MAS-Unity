using Assets.Scripts.Api;
using UnityEngine;

namespace Assets.Scripts.Monika
{
    internal struct MonikaHair : IMonikaHair
    {
        private readonly string _path, _back, _backLeaning, _front, _frontLeaning;

        public Sprite Back
        {
            get
            {
                string resource = Global.Monika.IsLeaning ? _backLeaning : _back;

                return MonikaUtil.GetSprite(_path + resource);
            }
        }
        public Sprite Front
        {
            get
            {
                string resource = Global.Monika.IsLeaning ? _frontLeaning : _front;

                return MonikaUtil.GetSprite(_path + resource);
            }
        }

        public string Name { get; private set; }

        public bool HasRibbon { get; private set; }

        public MonikaHair(string path, string hairName, string backName, string backNameLeaning, 
                          string frontName, string frontNameLeaning, bool hasRibbon)
        {
            _path = path;
            _back = backName;
            _backLeaning = backNameLeaning;
            _front = frontName;
            _frontLeaning = frontNameLeaning;

            Name = hairName;
            HasRibbon = hasRibbon;
        }

        public MonikaHair(string path, string hairName, bool hasRibbon)
        {
            _path = path;
            _back = "hair-" + hairName + "-back";
            _backLeaning = "hair-leaning-def-" + hairName + "-back";
            _front = "hair-" + hairName + "-front";
            _frontLeaning = "hair-leaning-def-" + hairName + "-front";

            Name = hairName;
            HasRibbon = hasRibbon;
        }
    }
}
