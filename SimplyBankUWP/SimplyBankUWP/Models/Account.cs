using System;
using GalaSoft.MvvmLight;

namespace SimplyBankUWP.Models
{
    public class Account : ObservableObject
    {
        private int _idAccount;
        private DateTime _lastOperation;
        private string _name;
        private string _accountNumber;
        private decimal _balanceCurrent;
        private decimal _balanceForecast;
        private decimal _balanceFistOfMonth;

        public int IdAccount
        {
            get
            {
                return _idAccount;
            }

            set { Set(() => IdAccount, ref _idAccount, value); }
        }

        public DateTime LastOperation
        {
            get
            {
                return _lastOperation;
            }

            set { Set(() => LastOperation, ref _lastOperation, value); }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set { Set(() => Name, ref _name, value); }
        }

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }

            set { Set(() => AccountNumber, ref _accountNumber, value); }
        }

        public decimal BalanceCurrent
        {
            get
            {
                return _balanceCurrent;
            }

            set { Set(() => BalanceCurrent, ref _balanceCurrent, value); }
        }

        public decimal BalanceForecast
        {
            get
            {
                return _balanceForecast;
            }

            set { Set(() => BalanceForecast, ref _balanceForecast, value); }
        }

        public decimal BalanceFistOfMonth
        {
            get
            {
                return _balanceFistOfMonth;
            }


            set { Set(() => BalanceFistOfMonth, ref _balanceFistOfMonth, value); }
        }
    }
}