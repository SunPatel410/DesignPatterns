using System;
using BridgePattern.Implementor;

namespace BridgePattern.ConcreteImplementor
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class CitiPaymentSystem : IPaymentSystem
    {
        public void ProcessPayement(string paymentSystem)
        {
            Console.WriteLine($"Using CitiBank gateway for {paymentSystem}");
        }
    }
}
