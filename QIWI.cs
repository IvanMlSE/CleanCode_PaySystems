namespace CleanCode_PaySystems
{
    public class QIWI : PaymentSystem
    {
        protected override string SetName() => nameof(PaymentSystemID.QIWI);

        protected override bool SetPaymentStatus() => true;

        protected override string SetMessage() => "Перевод на страницу QIWI...";
    }
}