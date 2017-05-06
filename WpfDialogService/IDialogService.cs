using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDialogService
{
    public interface IDialogService
    {
        void ShowDialogModal(DialogViewModelBase vm);
    }
}
