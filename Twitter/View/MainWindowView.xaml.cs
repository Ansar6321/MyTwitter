using System.Windows;
using Twitter.Interfaces;

namespace Twitter.View {
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window, IMainWindowView {
        public MainWindowView() {
            InitializeComponent();
        }

        public void BindDataContext(IMainWindowViewModel mainWindowViewModel) {
            this.DataContext = mainWindowViewModel;
        }

        public void ShowAlarm(string text, string caption) {
            MessageBox.Show(text, caption);
        }
    }
}
