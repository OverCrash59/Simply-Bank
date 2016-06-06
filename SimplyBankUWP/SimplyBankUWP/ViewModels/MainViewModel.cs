using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using GalaSoft.MvvmLight;
using SimplyBankUWP.Models;

namespace SimplyBankUWP.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Account _account;
        private ObservableCollection<Credit> _permanentCredits;
        private ObservableCollection<Flow> _permanentFlows;

        public Account Account
        {
            get
            {
                return _account;
            }


            set { Set(() => Account, ref _account, value); }
        }

        public ObservableCollection<Credit> PermanentCredits
        {
            get
            {
                return _permanentCredits;
            }


            set { Set(() => PermanentCredits, ref _permanentCredits, value); }
        }

        public ObservableCollection<Flow> PermanentFlows
        {
            get
            {
                return _permanentFlows;
            }


            set { Set(() => PermanentFlows, ref _permanentFlows, value); }
        }

        public MainViewModel()
        {
            Initialize();
        }
        private async void Initialize()
        {
            Account = await AccountDb.GetAccountAsync();
            PermanentCredits = await AccountDb.GetPeriodicCreditAsync();
            PermanentFlows = await AccountDb.GetPeriodicFlowAsync();
        }
    }
}
