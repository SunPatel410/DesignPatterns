using BridgePattern.Implementor;

namespace BridgePattern.Abstraction
{/// <summary>
/// Abstraction
/// </summary>
    public abstract class Payment
    {
        public IPaymentSystem _IPaymentSystem;
        public abstract void MakePayment();
    }
}
