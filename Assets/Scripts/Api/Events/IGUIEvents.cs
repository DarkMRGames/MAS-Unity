using System;

namespace Assets.Scripts.Api
{
    public interface IGUIEvents
    {
        event EventHandler<InterfaceVisibiltyEventArgs> InterfaceVisibiltyChanged;
    }

    public class InterfaceVisibiltyEventArgs : EventArgs
    {
        public readonly bool Visible;

        public InterfaceVisibiltyEventArgs(bool visible)
        {
            Visible = visible;
        }
    }
}
