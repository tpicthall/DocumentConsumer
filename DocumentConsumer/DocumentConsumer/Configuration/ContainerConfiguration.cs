using Autofac;
using DocumentConsumer.Main.Presenter;
using DocumentConsumer.Main.View;
using DocumentConsumer.Service;

namespace DocumentConsumer.Configuration
{
    internal class ContainerConfiguration
    {
        public static IContainer Container;

        public static void InitializeContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainView>().As<IMainView>().SingleInstance();
            builder.RegisterType<MainPresenter>().As<IMainPresenter>().SingleInstance();

            builder.RegisterType<FhirService>().As<IFhirService>().SingleInstance();

            Container = builder.Build();
        }
    }
}