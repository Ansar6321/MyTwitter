using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Twitter.Interfaces {
    public interface IMainWindowView {
        void ShowAlarm(string text, string caption);
        void BindDataContext(IMainWindowViewModel mainWindowViewModel);
        Dispatcher Dispatcher { get; }
    }
}
