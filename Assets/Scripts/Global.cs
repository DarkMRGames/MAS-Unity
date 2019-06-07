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
        internal static IDayTime DayTime { get; set; }
        internal static IGUIManager GUIManager { get; set; }
        internal static DialogBox Dialog { get; set; }

        private static readonly MonikaPose[] poses = new MonikaPose[]{
            "1nka", "1wtc", "1tfo", "1cuu", "1rsx"
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

            if (Input.GetKeyDown(KeyCode.L))
            {
                Monika.Pose = Monika.IsLeaning? "1eua" : "5eua";
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
