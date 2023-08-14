namespace CleanCode_PaySystems
{
    public class Card : PaymentSystem
    {
        protected override string SetName() => nameof(PaymentSystemID.Card);

        protected override bool SetPaymentStatus() => true;

        protected override string SetMessage() => "Вызов API банка эмитера карты Card...";
    }
}