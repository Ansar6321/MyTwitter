using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Twitter.Interfaces {
    public interface IShowUserWindowView {
        void ShowAlarm(string text, string caption);
        void BindDataContext(IShowUserWindowViewModel viewModel);
        Dispatcher Dispatcher { get; }
    }
}
