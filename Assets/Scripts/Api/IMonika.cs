using Assets.Scripts.Api;

namespace Assets.Scripts.Monika
{
    interface IMonika
    {
        bool Talking { get; set; }
        bool IsLeaning { get; }
        int Affection { get; }

        IMonikaHair Hair { set; }
        MonikaPose Pose { set; }

        void SetHair(string hairName);
    }
}
