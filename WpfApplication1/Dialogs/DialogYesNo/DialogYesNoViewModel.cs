using System;
using System.Windows;
using System.Windows.Input;
using WpfDialogService;

namespace WpfApplication1.Dialogs.DialogYesNo
{
    public class DialogYesNoViewModel : DialogViewModelBase
    {
        public event EventHandler YesClicked = delegate { };
        public event EventHandler NoClicked = delegate { };

        private ICommand yesCommand = null;
        public ICommand YesCommand
        {
            get { return yesCommand; }
            set { yesCommand = value; }
        }

        private ICommand noCommand = null;
        public ICommand NoCommand
        {
            get { return noCommand; }
            set { noCommand = value; }
        }

        public string Message { get; private set; }

        public DialogYesNoViewModel(string message)
        {
            Message = message;
            this.yesCommand = new RelayCommand(OnYesClicked);
            this.noCommand = new RelayCommand(OnNoClicked);
        }

        private void OnYesClicked(object parameter)
        {
            this.YesClicked(this, EventArgs.Empty);
            CloseDialog(parameter as Window);
        }

        private void OnNoClicked(object parameter)
        {
            this.NoClicked(this, EventArgs.Empty);
            CloseDialog(parameter as Window);
        }
    }
}
