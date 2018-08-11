using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Twitter.Interfaces {
    public interface ILoginWindowView {
        void ShowAlarm(string text, string caption);
        void BindDatacontext(ILoginWindowViewModel viewModel);
        Dispatcher Dispatcher { get; }
    }
}
