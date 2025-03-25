using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Design_Patterns
{
    using System;

    interface IPaymentStrategy
    {
        void Pay(int amount);
    }

    class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
    }

    class PayPalPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }
    }

    class BitcoinPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paid {amount} using Bitcoin.");
        }
    }

    class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout(int amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Please select a payment method before checking out.");
                return;
            }
            _paymentStrategy.Pay(amount);
        }
    }

    class Program
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            cart.SetPaymentStrategy(new CreditCardPayment());
            cart.Checkout(500);

            cart.SetPaymentStrategy(new PayPalPayment());
            cart.Checkout(300);

            cart.SetPaymentStrategy(new BitcoinPayment());
            cart.Checkout(200);
            Console.ReadLine();
        }
    }

}
