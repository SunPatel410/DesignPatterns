using System;
using BridgePattern.Implementor;

namespace BridgePattern.ConcreteImplementor
{    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class IDBIPaymentSystem: IPaymentSystem
    {
        public void ProcessPayement(string paymentSystem)
        {
            Console.WriteLine($"Using IDBIBank gateway for {paymentSystem}");
        }
    }
}
