using UnityEngine;

namespace Assets.Scripts.Monika
{
    static class MonikaUtil
    {
        public static Sprite GetSprite(string resourcePath)
        {
            if (Global.DayTime.IsNight)
                resourcePath += "-n";

            //TODO Maybe return the day version when the -n don't exist...
            return Resources.Load<Sprite>(resourcePath);
        }
    }
}
