using Ninject;

namespace WpfApplication1.ViewModels
{
    public class ViewModelLocator
    {
        private MainWindowViewModel mainWindowViewModel = null;
        public MainWindowViewModel MainWindowViewModel
        {
            get { return mainWindowViewModel; }
            set { mainWindowViewModel = value; }
        }

        public ViewModelLocator()
        {
            this.mainWindowViewModel =
               IoC.Container.Instance.Kernel.Get<MainWindowViewModel>();
        }
    }
}
