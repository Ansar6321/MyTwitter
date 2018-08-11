using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Interfaces;
using Twitter.Model;

namespace Twitter.ViewModel {
    public class ShowUserWindowViewModel : IShowUserWindowViewModel {
        public IShowUserWindowView View { get; private set; }

        public ShowUserWindowViewModel(IShowUserWindowView view, User user) {
            this.View = view;
            CurrentUser = user;
            Name = CurrentUser.Name;
            Surname = CurrentUser.Surname;
        }

        public User CurrentUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
