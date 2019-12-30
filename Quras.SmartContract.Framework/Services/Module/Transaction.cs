namespace Quras.SmartContract.Framework.Services.Module
{
    public class Transaction : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("Quras.Transaction.GetHash")]
            get;
        }

        public extern byte Type
        {
            [Syscall("Quras.Transaction.GetType")]
            get;
        }

        [Syscall("Quras.Transaction.GetAttributes")]
        public extern TransactionAttribute[] GetAttributes();

        [Syscall("Quras.Transaction.GetInputs")]
        public extern TransactionInput[] GetInputs();

        [Syscall("Quras.Transaction.GetOutputs")]
        public extern TransactionOutput[] GetOutputs();

        [Syscall("Quras.Transaction.GetReferences")]
        public extern TransactionOutput[] GetReferences();

        [Syscall("Quras.Transaction.GetUnspentCoins")]
        public extern TransactionOutput[] GetUnspentCoins();
    }
}
