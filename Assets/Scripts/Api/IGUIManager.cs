namespace Assets.Scripts.Api
{
    interface IGUIManager
    {
        bool IsInterfaceVisible { get; }

        void SetVisibility(bool visible);
    }
}
