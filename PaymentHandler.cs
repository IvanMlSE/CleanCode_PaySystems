using System;

namespace CleanCode_PaySystems
{
    public class PaymentHandler
    {
        public void ShowPaymentResult(PaymentSystem paymentSystem)
        {
            if (paymentSystem.PaymentSuccessful)
            {
                Console.WriteLine($"Вы оплатили с помощью {paymentSystem.Name}");
                Console.WriteLine($"Проверка платежа через {paymentSystem.Name}...");

                Console.WriteLine("Оплата прошла успешно!");
            }
            else
            {
                Console.WriteLine("Оплата не была произведена.");
            }
        }
    }
}