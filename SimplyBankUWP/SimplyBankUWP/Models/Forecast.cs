using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace SimplyBankUWP.Models
{
    public class Forecast : ObservableObject
    {
        private int _idForecast;
        private ObservableCollection<Credit> _credits;
        private ObservableCollection<Flow> _flows;

        public int IdForecast
        {
            get
            {
                return _idForecast;
            }

            set { Set(() => IdForecast, ref _idForecast, value); }
        }

        public ObservableCollection<Credit> Credits
        {
            get
            {
                return _credits;
            }

            set { Set(() => Credits, ref _credits, value); }
        }

        public ObservableCollection<Flow> Flows
        {
            get
            {
                return _flows;
            }

            set { Set(() => Flows, ref _flows, value); }
        }
    }
}