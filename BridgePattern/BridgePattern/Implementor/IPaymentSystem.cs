namespace BridgePattern.Implementor
{
    /// <summary>
    /// Implementor Interface
    /// </summary>
    public interface IPaymentSystem
    {
        void ProcessPayement(string paymentSystem);
    }
}
