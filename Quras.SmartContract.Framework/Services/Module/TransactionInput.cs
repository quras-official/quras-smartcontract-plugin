namespace Quras.SmartContract.Framework.Services.Module
{
    public class TransactionInput : IApiInterface
    {
        public extern byte[] PrevHash
        {
            [Syscall("Quras.Input.GetHash")]
            get;
        }

        public extern ushort PrevIndex
        {
            [Syscall("Quras.Input.GetIndex")]
            get;
        }
    }
}
