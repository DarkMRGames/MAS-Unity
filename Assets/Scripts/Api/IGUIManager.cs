namespace Assets.Scripts.Api
{
    interface IGUIManager : IGUIEvents
    {
        bool IsInterfaceVisible { get; }

        void SetVisibility(bool visible);
    }
}
