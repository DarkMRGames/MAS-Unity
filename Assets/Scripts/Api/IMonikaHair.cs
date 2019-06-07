using UnityEngine;

namespace Assets.Scripts.Api
{
    public interface IMonikaHair : INamedSprite
    {
        Sprite Back { get; }
        Sprite Front { get; }
        bool HasRibbon { get; }
    }
}
