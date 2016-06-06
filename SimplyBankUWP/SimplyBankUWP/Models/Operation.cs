using System;
using GalaSoft.MvvmLight;

namespace SimplyBankUWP.Models
{
    public abstract class Operation : ObservableObject
    {
        private DateTime _dateOperation;
        private Wording _wording;
        private TypeOperation _typeOperation;
        private DateTime _nextDeadline;
        private int _dayNumber;
        private Periodic _periodic;

        public DateTime DateOperation
        {
            get
            {
                return _dateOperation;
            }

            set { Set(() => DateOperation, ref _dateOperation, value); }
        }

        public Wording Wording
        {
            get
            {
                return _wording;
            }

            set { Set(() => Wording, ref _wording, value); }
        }

        public TypeOperation TypeOperation
        {
            get
            {
                return _typeOperation;
            }

            set { Set(() => TypeOperation, ref _typeOperation, value); }
        }

        public DateTime NextDeadline
        {
            get
            {
                return _nextDeadline;
            }

            set { Set(() => NextDeadline, ref _nextDeadline, value); }
        }

        public int DayNumber
        {
            get
            {
                return _dayNumber;
            }

            set { Set(() => DayNumber, ref _dayNumber, value); }
        }

        public Periodic Periodic
        {
            get
            {
                return _periodic;
            }

            set { Set(() => Periodic, ref _periodic, value); }
        }
    }
}