using Autofac;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.Presenter;
using DocumentConsumer.Main.View;
using DocumentConsumer.Service;

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

            builder.RegisterType<FHIRService>().As<IFHIRService>().SingleInstance();

            Container = builder.Build();
        }
    }
}
