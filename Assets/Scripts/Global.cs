using Assets.Scripts.Api;
using Assets.Scripts.GUI;
using Assets.Scripts.Monika;
using UnityEngine;

namespace Assets.Scripts
{
    class Global : MonoBehaviour
    {
        public readonly static IEvents Events = new EventManager();

        internal static IMonika Monika { get; set; }
        internal static DayTime DayTime { get; set; }
        internal static GUIManager GUIManager { get; set; }
        internal static DialogBox Dialog { get; set; }

        private bool _defHair = true, _defClothing = true;

        private static readonly MonikaPose[] poses = new MonikaPose[]{
            "1nka", "4wtc", "2tfo", "1cuu", "3rsx", "5etp", "5eua", "6ekb"
        };

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                if(!GUIManager.IsInterfaceVisible)
                {
                    GUIManager.SetVisibility(true);
                }
            }

            if(Input.GetMouseButtonDown(1))
            {
                GUIManager.SetVisibility(false);
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                Monika.Pose = poses[Random.Range(0, poses.Length - 1)];
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog.Text = "Ser ou não ser? eis a questão";
            }
            
            if (Input.GetKeyDown(KeyCode.H))
            {
                Monika.HairName = _defHair ? "down" : "def";
                _defHair = !_defHair;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                Monika.ClothingName = _defClothing ? "sundress_white" : "def";
                _defClothing = !_defClothing;
            }
        }
    }

    class EventManager : IEvents
    {
        public IDayTimeEvents DayTime
        {
            get
            {
                return Global.DayTime;
            }
        }

        public IGUIEvents GUI
        {
            get
            {
                return Global.GUIManager;
            }
        }
    }
}
