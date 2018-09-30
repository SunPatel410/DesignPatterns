using System;
using BridgePattern.Abstraction;

namespace BridgePattern.RefinedAbstraction
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayement("NetBanking Payment");
        }
    }
}
