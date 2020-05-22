using GalaSoft.MvvmLight;
using SyntraCalc.UI.WPF.Messages;

namespace SyntraCalc.UI.WPF.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        #region Fields
        private string _currentPage;
        private string _startPageName = "Dashboard";
        private string _headerTitle = "geometric shape calculator";
        #endregion

        #region Properties
        public string CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                RaisePropertyChanged();
            }
        }

        public string HeaderTitle { get; set; }

        #endregion

        #region Constructors
        public MainViewModel()
        {
            CurrentPage = _startPageName;
            HeaderTitle = _headerTitle;
            MessengerInstance.Register<FrameNavigationMessage>(this, SetFrameNavigation);

        }
        #endregion

        #region Methods

        private void SetFrameNavigation(FrameNavigationMessage message)
        {
            CurrentPage = message.PageName;
        }

        #endregion

    }
}
