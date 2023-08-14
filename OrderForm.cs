using System;

namespace CleanCode_PaySystems
{
    public class OrderForm
    {
        public PaymentSystem ShowForm()
        {
            Console.WriteLine($"Мы принимаем: {nameof(PaymentSystemID.QIWI)}, {nameof(PaymentSystemID.WebMoney)}, {nameof(PaymentSystemID.Card)}");

            // симуляция веб интерфейса
            Console.WriteLine("Какое системой вы хотите совершить оплату?");

            string paymentSystemID = Console.ReadLine();

            switch (paymentSystemID)
            {
                case nameof(PaymentSystemID.QIWI):
                    return new QIWI();
                case nameof(PaymentSystemID.WebMoney):
                    return new WebMoney();
                case nameof(PaymentSystemID.Card):
                    return new Card();
                default:
                    return new IndefinitePaymentSystem();
            }
        }
    }
}