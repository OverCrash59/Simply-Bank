using GalaSoft.MvvmLight;

namespace SimplyBankUWP.Models
{
    public class Wording : ObservableObject
    {
        private int _idWording;
        private string _wordingName;

        public int IdWording
        {
            get
            {
                return _idWording;
            }

            set { Set(() => IdWording, ref _idWording, value); }
        }

        public string WordingName
        {
            get
            {
                return _wordingName;
            }


            set { Set(() => WordingName, ref _wordingName, value); }
        }
    }
}