using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDialogService
{
    public class DialogViewModelBase
    {
        public Window Owner { get; set; }

        public void CloseDialog(Window view)
        {
            if (view != null)
                view.DialogResult = true;
        }
    }
}
