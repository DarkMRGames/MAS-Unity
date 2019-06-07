using Assets.Scripts.Api;
using UnityEngine;

namespace Assets.Scripts.Monika
{
    struct MonikaClothing : IMonikaClothing
    {
        private readonly string
            _path, 
            _armsCrossed, _armsDown, _armsLeaning, _armsPointRight, _armsRestLeftPointRight,
            _armsSteepling, _body, _bodyLeaning;

        #region Properties

        public Sprite ArmsCrossed
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _armsCrossed);
            }
        }

        public Sprite ArmsDown
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _armsDown);
            }
        }

        public Sprite ArmsLeaning
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _armsLeaning);
            }
        }

        public Sprite ArmsPointRight
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _armsPointRight);
            }
        }

        public Sprite ArmsRestLeftPointRight
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _armsRestLeftPointRight);
            }
        }

        public Sprite ArmsSteepling
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _armsSteepling);
            }
        }

        public Sprite Body
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _body);
            }
        }

        public Sprite BodyLeaning
        {
            get
            {
                return MonikaUtil.GetSprite(_path + _bodyLeaning);
            }
        }

        public string Name { get; private set; }

        #endregion

        public MonikaClothing(string path, string name)
        {
            _path = path;
            _armsCrossed = "arms-crossed";
            _armsDown = "arms-down";
            _armsLeaning = "arms-leaning-def-def";
            _armsPointRight = "arms-pointright";
            _armsRestLeftPointRight = "arms-restleftpointright";
            _armsSteepling = "arms-steepling";
            _body = "body-def";
            _bodyLeaning = "body-leaning-def";

            Name = name;
        }
    }
}
