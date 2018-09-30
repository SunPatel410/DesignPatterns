 using System;
 using BridgePattern.Abstraction;
 using BridgePattern.ConcreteImplementor;
 using BridgePattern.RefinedAbstraction;

namespace BridgePattern
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Payment order = new CardPayment();

            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            Console.ReadKey();
        }
    }
}
