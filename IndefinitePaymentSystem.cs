namespace CleanCode_PaySystems
{
    public class IndefinitePaymentSystem : PaymentSystem
    {
        protected override string SetName() => string.Empty;

        protected override bool SetPaymentStatus() => false;

        protected override string SetMessage() => "Этот способ оплаты недоступен";
    }
}