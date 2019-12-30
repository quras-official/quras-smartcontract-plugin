namespace Quras.SmartContract.Framework.Services.Module
{
    public class Contract
    {
        public extern byte[] Script
        {
            [Syscall("Quras.Contract.GetScript")]
            get;
        }
       
        public extern bool IsPayable
        {
            [Syscall("Quras.Contract.IsPayable")]
            get;
        }

        public extern StorageContext StorageContext
        {
            [Syscall("Quras.Contract.GetStorageContext")]
            get;
        }

        [Syscall("Quras.Contract.Create")]
        public static extern Contract Create(byte[] script, byte[] parameter_list, byte return_type, bool need_storage, string name, string version, string author, string email, string description);

        [Syscall("Quras.Contract.Migrate")]
        public static extern Contract Migrate(byte[] script, byte[] parameter_list, byte return_type, bool need_storage, string name, string version, string author, string email, string description);

        [Syscall("Quras.Contract.Destroy")]
        public static extern void Destroy();
    }
}
