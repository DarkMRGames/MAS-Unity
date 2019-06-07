using Assets.Scripts.Api;
using UnityEngine;

namespace Assets.Scripts
{
    sealed class DayTimeTexture : MonoBehaviour
    {
        public Sprite Day;
        public Sprite Night;
        
        private void Start()
        {
            GetComponent<SpriteRenderer>().sprite = Global.DayTime.IsDay? Day : Night;
            Global.Events.DayTime.DayTimeChange += OnDayTimeChange;
        }

        private void OnDestroy()
        {
            Global.Events.DayTime.DayTimeChange -= OnDayTimeChange;
        }

        private void OnDayTimeChange(object sender, DayTimeChangeEventArgs e)
        {
            GetComponent<SpriteRenderer>().sprite = e.IsDay ? Day : Night;
        }
    }
}
