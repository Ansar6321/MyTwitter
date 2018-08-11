using Autofac;
using System.Windows;
using Twitter.Interfaces;
using Twitter.Services;
using Twitter.View;
using Twitter.ViewModel;

namespace Twitter {
    public partial class App : Application {
        static public IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainWindowView>().As<IMainWindowView>();
            containerBuilder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();
            containerBuilder.RegisterType<FakeFeedService>().As<IFeedService>();
            containerBuilder.RegisterType<ShowUserWindowView>().As<IShowUserWindowView>();
            containerBuilder.RegisterType<ShowUserWindowViewModel>().As<IShowUserWindowViewModel>();
            containerBuilder.RegisterType<LoginWindowView>().As<ILoginWindowView>();
            containerBuilder.RegisterType<LoginWindowViewModel>().As<ILoginWindowViewModel>();
            //еще какие-то сервисы можно сюда добавить
            Container = containerBuilder.Build();
            var MainWindowViewModel = Container.Resolve<ILoginWindowViewModel>();
            this.MainWindow = MainWindowViewModel.View as Window;
            this.MainWindow.Show();
        }
    }
}
