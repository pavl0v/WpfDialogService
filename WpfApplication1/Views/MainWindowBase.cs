using System.Windows;
using WpfApplication1.ViewModels;
using WpfDialogService;

namespace WpfApplication1.Views
{
    public class MainWindowBase : Window
    {
        public IDialogService DialogService
        {
            get { return (IDialogService)GetValue(DialogServiceProperty); }
            set { SetValue(DialogServiceProperty, value); }
        }

        public static readonly DependencyProperty DialogServiceProperty =
            DependencyProperty.Register("DialogService", typeof(IDialogService), typeof(MainWindowBase), new PropertyMetadata(null, PropertyChangedCallback));

        static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Window v = d as Window;
            if (v == null)
                return;

            MainWindowViewModel vm = v.DataContext as MainWindowViewModel;
            if (vm == null)
                return;

            IDialogService ds = e.NewValue as IDialogService;
            if (ds == null)
                return;

            vm.DialogService = ds;
        }
    }
}
