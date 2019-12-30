namespace Quras.SmartContract.Framework.Services.Module
{
    public class Account
    {
        public extern byte[] ScriptHash
        {
            [Syscall("Quras.Account.GetScriptHash")]
            get;
        }

        public extern byte[][] Votes
        {
            [Syscall("Quras.Account.GetVotes")]
            get;
        }

        [Syscall("Quras.Account.GetBalance")]
        public extern long GetBalance(byte[] asset_id);
    }
}
