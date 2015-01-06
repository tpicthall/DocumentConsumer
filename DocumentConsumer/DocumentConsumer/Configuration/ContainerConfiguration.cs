using Autofac;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.Presenter;
using DocumentConsumer.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConsumer.Configuration
{
    class ContainerConfiguration
    {
        public static IContainer Container;

        public static void InitializeContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainModel>().As<IMainModel>().SingleInstance();
            builder.RegisterType<MainView>().As<IMainView>().SingleInstance();
            builder.RegisterType<MainPresenter>().As<IMainPresenter>().SingleInstance();

            Container = builder.Build();
        }
    }
}
