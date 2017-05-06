using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfDialogService;

namespace WpfApplication1.ViewModels
{
    public class MainWindowViewModel
    {
        public IDialogService DialogService { get; set; }

        private ICommand openDialogCommand = null;
        public ICommand OpenDialogCommand
        {
            get { return this.openDialogCommand; }
            set { this.openDialogCommand = value; }
        }

        public MainWindowViewModel()
        {
            this.openDialogCommand = new RelayCommand(OnOpenDialog);
        }

        private void OnOpenDialog(object parameter)
        {
            var vm = new Dialogs.DialogYesNo.DialogYesNoViewModel("Question");
            vm.YesClicked += OptionYes;
            vm.NoClicked += OptionNo;
            vm.Owner = parameter as Window;
            if (DialogService != null)
                DialogService.ShowDialogModal(vm);
        }

        private void OptionYes(object sender, EventArgs e)
        {

        }

        private void OptionNo(object sender, EventArgs e)
        {

        }
    }
}
