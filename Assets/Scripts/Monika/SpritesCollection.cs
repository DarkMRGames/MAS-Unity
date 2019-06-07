using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Monika
{
    internal sealed class SpritesCollection : Dictionary<string, string>
    {
        private readonly string _resourcePath;

        public Sprite GetSprite(string key)
        {
            return MonikaUtil.GetSprite(_resourcePath + this[key]);
        }

        internal SpritesCollection(string resourcePath)
        {
            _resourcePath = resourcePath;
        }
    }
}
