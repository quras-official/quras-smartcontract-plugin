namespace Quras.SmartContract.Framework.Services.Module
{
    public class Iterator<TKey, TValue>
    {
        [Syscall("Quras.Iterator.Next")]
        public extern bool Next();

        public extern TKey Key
        {
            [Syscall("Quras.Iterator.Key")]
            get;
        }

        public extern TValue Value
        {
            [Syscall("Quras.Iterator.Value")]
            get;
        }
    }
}
