using UnityEngine;

namespace Assets.Scripts.Api
{
    public interface IMonikaHair
    {
        Sprite Back { get; }
        Sprite Front { get; }
        bool HasRibbon { get; }
    }
}
