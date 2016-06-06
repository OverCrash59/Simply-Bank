using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace SimplyBankUWP.Models
{
    public class Current : ObservableObject
    {
        private int _idCurrent;
        private ObservableCollection<Credit> _credits;
        private ObservableCollection<Flow> _flows;

        public int IdCurrent
        {
            get
            {
                return _idCurrent;
            }

            set { Set(() => IdCurrent, ref _idCurrent, value); }
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