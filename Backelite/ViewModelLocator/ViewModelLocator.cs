using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace $rootnamespace$
{
    public class $safeitemname$
    {

        #region public MainViewModel MainViewModel

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        #endregion
        
        public $safeitemname$()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            Register<MainViewModel>();
        }

        public static void Register<T>() where T : ViewModelBase
        {
            if (SimpleIoc.Default.IsRegistered<T>())
            {
                SimpleIoc.Default.Unregister<T>();
            }

            SimpleIoc.Default.Register<T>();
        }
    }
}
