namespace CleanCode_PaySystems
{
    public class WebMoney : PaymentSystem
    {
        protected override string SetName() => nameof(PaymentSystemID.WebMoney);

        protected override bool SetPaymentStatus() => true;

        protected override string SetMessage() => "Вызов API WebMoney...";
    }
}