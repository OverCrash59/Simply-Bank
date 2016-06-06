using GalaSoft.MvvmLight;

namespace SimplyBankUWP.Models
{
    public class TypeOperation : ObservableObject
    {
        private int _idType;
        private string _name;

        public int IdType
        {
            get
            {
                return _idType;
            }

            set { Set(() => IdType, ref _idType, value); }
        }

        public string Name
        {
            get
            {
                return _name;
            }


            set { Set(() => Name, ref _name, value); }
        }
    }
}