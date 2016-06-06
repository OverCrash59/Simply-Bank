namespace SimplyBankUWP.Models
{
    public class Flow : Operation
    {
        private int _idFlow;
        private decimal _amount;
        private bool _pointed;

        public int IdFlow
        {
            get
            {
                return _idFlow;
            }

            set { Set(() => IdFlow, ref _idFlow, value); }
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