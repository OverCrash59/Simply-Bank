namespace SimplyBankUWP.Models
{
    public class Credit : Operation
    {
        private int _idCredit;
        private decimal _amount;
        private bool _pointed;

        public int IdCredit
        {
            get
            {
                return _idCredit;
            }

            set { Set(() => IdCredit, ref _idCredit, value); }
        }

        public decimal Amount
        {
            get
            {
                return _amount;
            }

            set { Set(() => Amount, ref _amount, value); }
        }

        public bool Pointed
        {
            get
            {
                return _pointed;
            }

            set { Set(() => Pointed, ref _pointed, value); }
        }
    }
}