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

namespace Twitter.View {
    /// <summary>
    /// Interaction logic for ShowUserWindowView.xaml
    /// </summary>
    public partial class ShowUserWindowView : Window, IShowUserWindowView {
        public ShowUserWindowView() {
            InitializeComponent();
        }

        public void BindDataContext(IShowUserWindowViewModel viewModel) {
            this.DataContext = viewModel;
        }

        public void ShowAlarm(string text, string caption) {
            throw new NotImplementedException();
        }
    }
}
