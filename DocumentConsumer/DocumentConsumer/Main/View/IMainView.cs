using System;
using System.Collections.Generic;
using DocumentConsumer.Main.Handler;

namespace DocumentConsumer.Main.View
{
    interface IMainView
    {
        void SetMainHandler(IMainHandler mainHandler);

        void ShowView();

        void CloseView();

        void UpdateStatusBarConnection(string text);

        void EnableDocumentButtons(bool enable);

        void FillResults<T>(Type resultType, List<T> results);
    }
}
