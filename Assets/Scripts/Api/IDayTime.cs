using Assets.Scripts.Api;

namespace Assets.Scripts
{
    interface IDayTime : IDayTimeEvents
    {
        bool IsDay { get; }
        bool IsNight { get; }
    }
}
