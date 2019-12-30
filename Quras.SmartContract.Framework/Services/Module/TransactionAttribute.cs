namespace Quras.SmartContract.Framework.Services.Module
{
    public class TransactionAttribute : IApiInterface
    {
        public extern byte Usage
        {
            [Syscall("Quras.Attribute.GetUsage")]
            get;
        }

        public extern byte[] Data
        {
            [Syscall("Quras.Attribute.GetData")]
            get;
        }
    }
}
