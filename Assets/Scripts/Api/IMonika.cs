namespace Assets.Scripts.Monika
{
    interface IMonika
    {
        bool Talking { get; set; }
        bool IsLeaning { get; }
        int Affection { get; }
        MonikaPose Pose { set; }
    }
}
