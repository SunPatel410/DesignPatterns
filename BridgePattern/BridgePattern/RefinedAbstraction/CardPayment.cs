using BridgePattern.Abstraction;

namespace BridgePattern.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
           _IPaymentSystem.ProcessPayement("Card Payment");
        }
    }
}
