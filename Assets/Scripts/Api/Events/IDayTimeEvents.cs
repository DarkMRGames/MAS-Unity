using System;

namespace Assets.Scripts.Api
{
    public interface IDayTimeEvents
    {
        event EventHandler<DayTimeChangeEventArgs> DayTimeChange;
    }

    public class DayTimeChangeEventArgs : EventArgs
    {
        public readonly bool IsDay;

        public DayTimeChangeEventArgs(bool isDay)
        {
            IsDay = isDay;
        }
    }
}
