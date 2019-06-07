namespace Assets.Scripts.Api
{
    public interface IEvents
    {
        IDayTimeEvents DayTime { get; }
        IGUIEvents GUI { get; }
    }
}
