using System;

namespace CleanCode_PaySystems
{
    public abstract class PaymentSystem
    {
        public string Name => SetName();

        public bool PaymentSuccessful { get; private set; }

        public void ShowMessage()
        {
            Console.WriteLine(SetMessage());
        }

        public void Pay()
        {
            PaymentSuccessful = SetPaymentStatus();
        }

        protected abstract string SetName();

        protected abstract bool SetPaymentStatus();

        protected abstract string SetMessage();
    }
}
