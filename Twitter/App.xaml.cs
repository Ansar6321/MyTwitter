using Autofac;
using System.Windows;
using Twitter.Interfaces;
using Twitter.Services;
using Twitter.View;
using Twitter.ViewModel;

namespace Twitter {
    public partial class App : Application {
        public IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<MainWindowView>().As<IMainWindowView>();
            containerBuilder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();
            containerBuilder.RegisterType<FakeFeedService>().As<IFeedService>();
            //еще какие-то сервисы можно сюда добавить
            Container = containerBuilder.Build();
            var MainWindowViewModel = Container.Resolve<IMainWindowViewModel>();
            this.MainWindow = MainWindowViewModel.View as Window;
            this.MainWindow.Show();
        }
    }
}
