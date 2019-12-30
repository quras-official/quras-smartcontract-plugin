namespace Quras.SmartContract.Framework.Services.Module
{
    public class Block : Header
    {
        [Syscall("Quras.Block.GetTransactionCount")]
        public extern int GetTransactionCount();

        [Syscall("Quras.Block.GetTransactions")]
        public extern Transaction[] GetTransactions();

        [Syscall("Quras.Block.GetTransaction")]
        public extern Transaction GetTransaction(int index);
    }
}
