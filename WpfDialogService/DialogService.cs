using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDialogService
{
    public class DialogService : IDialogService
    {
        public void ShowDialogModal(DialogViewModelBase vm)
        {
            DialogView v = new DialogView();
            v.Owner = vm.Owner;
            v.DataContext = vm;
            v.ShowDialog();
            v.Owner = null;
        }
    }
}
