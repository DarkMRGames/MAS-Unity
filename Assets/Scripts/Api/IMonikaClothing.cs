using UnityEngine;

namespace Assets.Scripts.Api
{
    public interface IMonikaClothing : INamedSprite
    {
        Sprite ArmsCrossed { get; }
        Sprite ArmsDown { get; }
        Sprite ArmsLeaning { get; }
        Sprite ArmsPointRight { get; }
        Sprite ArmsRestLeftPointRight { get; }
        Sprite ArmsSteepling { get; }

        Sprite Body { get; }
        Sprite BodyLeaning { get; }
    }
}
