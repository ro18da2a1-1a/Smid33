using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Smid33
{
    class RC:ICommand
    {

        private Action<String> _action;

        public RC(Action<String> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!(parameter is PointerRoutedEventArgs args))
                _action("");
            else
            {
                ListViewItemPresenter cont = args.OriginalSource as ListViewItemPresenter;
                if (cont != null)
                {
                    _action(cont.Content.ToString());
                }
                else
                {
                    _action("");
                }

            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
