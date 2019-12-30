namespace Quras.SmartContract.Framework.Services.Module
{
    public class Asset
    {
        public extern byte[] AssetId
        {
            [Syscall("Quras.Asset.GetAssetId")]
            get;
        }

        public extern byte AssetType
        {
            [Syscall("Quras.Asset.GetAssetType")]
            get;
        }

        public extern long Amount
        {
            [Syscall("Quras.Asset.GetAmount")]
            get;
        }

        public extern long Available
        {
            [Syscall("Quras.Asset.GetAvailable")]
            get;
        }

        public extern byte Precision
        {
            [Syscall("Quras.Asset.GetPrecision")]
            get;
        }

        public extern byte[] Owner
        {
            [Syscall("Quras.Asset.GetOwner")]
            get;
        }

        public extern byte[] Admin
        {
            [Syscall("Quras.Asset.GetAdmin")]
            get;
        }

        public extern byte[] Issuer
        {
            [Syscall("Quras.Asset.GetIssuer")]
            get;
        }

        [Syscall("Quras.Asset.Create")]
        public static extern Asset Create(byte asset_type, string name, long amount, byte precision, byte[] owner, byte[] admin, byte[] issuer);

        [Syscall("Quras.Asset.Renew")]
        public extern uint Renew(byte years);
    }
}
