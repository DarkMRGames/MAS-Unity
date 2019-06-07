using Assets.Scripts.Api;
using Assets.Scripts.Common;
using System;
using UnityEngine;

namespace Assets.Scripts
{
    sealed class DayTime : MonoBehaviour, IDayTime, IDayTimeEvents
    {
        public event EventHandler<DayTimeChangeEventArgs> DayTimeChange;
        private bool _isDayOnTheLastFrame;

        public bool IsDay
        {
            get
            {
                return DateTime.Now.Hour.Between(5, 18);
            }
        }

        public bool IsNight {
            get
            {
                return !IsDay;
            }
        }
        
        private void Awake()
        {
            Global.DayTime = this;
            _isDayOnTheLastFrame = IsDay;
        }

        private void Update()
        {
            bool isDay = IsDay;

            if (_isDayOnTheLastFrame != isDay)
            {
                _isDayOnTheLastFrame = isDay;

                if(DayTimeChange != null)
                    DayTimeChange.Invoke(this, new DayTimeChangeEventArgs(isDay));
            }
        }

        /*private void OnDestroy()
        {
            Global.DayTime = null;
        }*/
    }
}
