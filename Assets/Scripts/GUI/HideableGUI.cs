using Assets.Scripts.Api;
using UnityEngine;

namespace Assets.Scripts.GUI
{
    sealed class HideableGUI : MonoBehaviour
    {
        private void Start()
        {
            Global.Events.GUI.InterfaceVisibiltyChanged += OnInterfaceVisibilityChanged;
        }

        private void OnDestroy()
        {
            Global.Events.GUI.InterfaceVisibiltyChanged -= OnInterfaceVisibilityChanged;
        }

        private void OnInterfaceVisibilityChanged(object sender, InterfaceVisibiltyEventArgs e)
        {
            gameObject.SetActive(e.Visible);
        }
    }
}
