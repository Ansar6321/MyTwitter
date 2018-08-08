using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Twitter.Common {
    public class RelayCommand : ICommand {
        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public RelayCommand(Action<object> execute,
                    Predicate<object> canExecute = null) {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter) {
            return this.canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter) {
            this.execute.Invoke(parameter);
        }
    }
}
