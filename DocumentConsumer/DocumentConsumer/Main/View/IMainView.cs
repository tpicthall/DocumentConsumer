using DocumentConsumer.Main.Handler;

namespace DocumentConsumer.Main.View
{
    interface IMainView
    {
        void SetMainHandler(IMainHandler mainHandler);

        void ShowView();

        void CloseView();
    }
}
