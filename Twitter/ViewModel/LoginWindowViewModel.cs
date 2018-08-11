using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.Interfaces;
using Twitter.Common;
using System.Windows.Input;

namespace Twitter.ViewModel {
    public class LoginWindowViewModel : NotifyObject, ILoginWindowViewModel {
        public ILoginWindowView View { get; private set; }

        public LoginWindowViewModel(ILoginWindowView view) {
            this.View = view;
        }
        private string signIn_Login;
        public string SignIn_Login {
            get { return signIn_Login; }
            set {
                signIn_Login = value;
                OnpropertyChanged();
            }
        }

        private string signIn_Password;
        public string SignIn_Password {
            get {
                return signIn_Password;
            }
            set {
                signIn_Password = value;
                OnpropertyChanged();
            }
        }

        private string name;
        public string Name {
            get { return name; }
            set {
                name = value;
                OnpropertyChanged();
            }
        }

        private string surname;
        public string Surname {
            get { return surname; }
            set { surname = value;
                OnpropertyChanged();
            }
        }

        private string imagePath;
        public string ImagePath {
            get { return imagePath; }
            set { imagePath = value;
                OnpropertyChanged();
            }
        }

        private string signUp_Login;
        public string SignUp_Login {
            get { return signUp_Login; }
            set { signUp_Login = value;
                OnpropertyChanged();
            }
        }

        private string signUp_Password;
        public string SignUp_Password {
            get { return signUp_Password; }
            set { signUp_Password = value;
                OnpropertyChanged();
            }
        }


        private ICommand signInCommand;
        public ICommand SignInCommand {
            get {
                if (this.signInCommand is null) {
                    this.signInCommand = new RelayCommand(
                        (param) => {
                            SignIn_Login = string.Empty;
                        },
                        (param) => {

                            return true;
                        }
                    );
                }
                return this.signInCommand;
            }
        }

        private ICommand signUpCommand;
        public ICommand SignUpCommand {
            get {
                if (this.signUpCommand is null) {
                    this.signUpCommand = new RelayCommand(
                        (param) => {

                        },
                        (param) => {

                            return true;
                        }
                    );
                }
                return this.signUpCommand;
            }
        }
    }
}
