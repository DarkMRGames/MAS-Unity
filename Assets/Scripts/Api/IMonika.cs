using Assets.Scripts.Api;

namespace Assets.Scripts.Monika
{
    interface IMonika
    {
        bool Talking { get; set; }
        bool IsLeaning { get; }
        int Affection { get; }

        IMonikaHair Hair { set; }
        IMonikaClothing Clothing { set; }
        MonikaPose Pose { set; }

        string HairName { set; }
        string ClothingName { set; }
    }
}
