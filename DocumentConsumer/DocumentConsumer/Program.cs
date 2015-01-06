using Autofac;
using DocumentConsumer.Configuration;
using DocumentConsumer.Main.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentConsumer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ContainerConfiguration.InitializeContainer();

            IMainPresenter mainPresenter = ContainerConfiguration.Container.Resolve<IMainPresenter>();
            mainPresenter.Initialize();
            mainPresenter.ShowView();
        }
    }
}
