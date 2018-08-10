using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using System.Windows.Threading;
using Twitter.Common;
using Twitter.Interfaces;
using Twitter.Model;
using Autofac;
using Twitter.View;
using Autofac.Core;
using System.Windows;

namespace Twitter.ViewModel {
    public class MainWindowViewModel : NotifyObject, IMainWindowViewModel {
        public IMainWindowView View { get; private set; }
        public IFeedService FeedService { get; private set; }
        public MainWindowViewModel(IMainWindowView view, IFeedService feedService) {
            this.View = view;
            this.FeedService = feedService;
            this.View.BindDataContext(this);
            Publications = new ObservableCollection<Publication>();
            UpdateTimer = new Timer(10000);
            UpdateFeed();
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
            CurrentUser = new User {
                Id = 1,
                ImagePath = "dkcns",
                Login = "login",
                Name = "Rohan",
                Password = "password",
                Surname = "Surname"
            };
        }

        private void UpdateTimer_Elapsed(object sender, ElapsedEventArgs e) {
            UpdateFeed();
        }

        private void UpdateFeed() {
            View.Dispatcher.Invoke(() => {
                Publications.Clear();
                var temp = FeedService.GetPublications();
                foreach (var item in temp) {
                    Publications.Add(item);
                }
            });
        }

        public Timer UpdateTimer { get; set; }

        public User CurrentUser { get; set; }
        public string ImagePath { get; set; }
        public string UserName { get; set; }
        public ObservableCollection<Publication> Publications { get; set; }

        private ICommand addPublication;
        public ICommand AddPublication {
            get {
                if (this.addPublication is null) {
                    this.addPublication = new RelayCommand(
                        (param) => {

                        },
                        (param) => {

                            return true;
                        }
                    );
                }
                return this.addPublication;
            }
        }

        private ICommand showUser;
        public ICommand ShowUser {
            get {
                if (this.showUser is null) {
                    this.showUser = new RelayCommand(
                        (param) => {
                            
                            var showUserWindowViewModel = App.Container.Resolve<IShowUserWindowViewModel>(new NamedParameter("user", CurrentUser));
                            var showUserWindowView = showUserWindowViewModel.View as Window;
                            showUserWindowView.Show();
                        },
                        (param) => {

                            return true;
                        }
                    );
                }
                return this.showUser;
            }
        }
    }
}
