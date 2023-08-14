namespace CleanCode_PaySystems
{
    public class PaymentSystemsHandler
    {
        public void MakePayment()
        {
            OrderForm orderForm = new OrderForm();
            PaymentHandler paymentHandler = new PaymentHandler();

            PaymentSystem systemId = orderForm.ShowForm();

            systemId.ShowMessage();

            systemId.Pay();

            paymentHandler.ShowPaymentResult(systemId);
        }
    }
}