using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Twitter.Interfaces;
using Twitter.Common;

namespace Twitter.View {
    /// <summary>
    /// Interaction logic for LoginWindowView.xaml
    /// </summary>
    public partial class LoginWindowView : Window, ILoginWindowView {
        public LoginWindowView() {
            InitializeComponent();
        }

        public void BindDatacontext(ILoginWindowViewModel viewModel) {
            this.DataContext = viewModel;
        }

        public void ShowAlarm(string text, string caption) {
            MessageBox.Show(text, caption);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            tabControl.TabIndex = 1;
        }
    }
}
