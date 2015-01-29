using System.Collections.Generic;
using DocumentConsumer.Main.Handler;

namespace DocumentConsumer.Main.View
{
    internal interface IMainView
    {
        void SetMainHandler(IMainHandler mainHandler);

        void ShowView();

        void CloseView();

        void UpdateStatusBarConnection(string text);

        void EnableDocumentButtons(bool enable);

        void FillResults<T>(List<T> results);

        void FillOutput(string output);

        void FillRequestResponse(string requestResponse);
    }
}