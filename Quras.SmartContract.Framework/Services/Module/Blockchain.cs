namespace Quras.SmartContract.Framework.Services.Module
{
    public static class Blockchain
    {
        [Syscall("Quras.Blockchain.GetHeight")]
        public static extern uint GetHeight();

        [Syscall("Quras.Blockchain.GetHeader")]
        public static extern Header GetHeader(uint height);

        [Syscall("Quras.Blockchain.GetHeader")]
        public static extern Header GetHeader(byte[] hash);

        [Syscall("Quras.Blockchain.GetBlock")]
        public static extern Block GetBlock(uint height);

        [Syscall("Quras.Blockchain.GetBlock")]
        public static extern Block GetBlock(byte[] hash);

        [Syscall("Quras.Blockchain.GetTransaction")]
        public static extern Transaction GetTransaction(byte[] hash);

        [Syscall("Quras.Blockchain.GetAccount")]
        public static extern Account GetAccount(byte[] script_hash);

        [Syscall("Quras.Blockchain.GetValidators")]
        public static extern byte[][] GetValidators();

        [Syscall("Quras.Blockchain.GetAsset")]
        public static extern Asset GetAsset(byte[] asset_id);

        [Syscall("Quras.Blockchain.GetContract")]
        public static extern Contract GetContract(byte[] script_hash);
    }
}
