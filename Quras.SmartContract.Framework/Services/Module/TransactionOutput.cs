namespace Quras.SmartContract.Framework.Services.Module
{
    public class TransactionOutput : IApiInterface
    {
        public extern byte[] AssetId
        {
            [Syscall("Quras.Output.GetAssetId")]
            get;
        }

        public extern long Value
        {
            [Syscall("Quras.Output.GetValue")]
            get;
        }

        public extern byte[] ScriptHash
        {
            [Syscall("Quras.Output.GetScriptHash")]
            get;
        }
    }
}
