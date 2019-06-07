using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Monika
{
    internal sealed class SpritesCollection : Dictionary<string, string>
    {
        private readonly string _resourcePath;

        public Sprite GetSprite(string key)
        {
            string resource = _resourcePath + this[key];

            if (Global.DayTime.IsNight)
                resource += "-n";

            return Resources.Load<Sprite>(resource);
        }

        internal SpritesCollection(string resourcePath)
        {
            _resourcePath = resourcePath;
        }
    }
}
