using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Common {
    public class NotifyObject : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged([CallerMemberName]string param = "") {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }
    }
}
