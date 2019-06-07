using Assets.Scripts.Api;
using System;
using UnityEngine;

namespace Assets.Scripts
{
    sealed class GUIManager : MonoBehaviour, IGUIManager, IGUIEvents
    {
        public event EventHandler<InterfaceVisibiltyEventArgs> InterfaceVisibiltyChanged;
        private bool _visibleInterface = true;

        public bool IsInterfaceVisible
        {
            get
            {
                return _visibleInterface;
            }
        }

        public void SetVisibility(bool visible)
        {
            if (_visibleInterface == visible)
                return;

            InterfaceVisibiltyEventArgs args = new InterfaceVisibiltyEventArgs(visible);

            if (InterfaceVisibiltyChanged != null)
                InterfaceVisibiltyChanged.Invoke(this, args);

            _visibleInterface = visible;
        }

        private void Awake()
        {
            Global.GUIManager = this;
        }

        /*private void OnDestroy()
        {
            Global.GUIManager = null;
        }*/
    }
}
