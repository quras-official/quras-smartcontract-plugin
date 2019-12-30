namespace Quras.SmartContract.Framework.Services.Module
{
    public static class Runtime
    {
        public static extern TriggerType Trigger
        {
            [Syscall("Quras.Runtime.GetTrigger")]
            get;
        }

        public static extern uint Time
        {
            [Syscall("Quras.Runtime.GetTime")]
            get;
        }

        [Syscall("Quras.Runtime.CheckWitness")]
        public static extern bool CheckWitness(byte[] hashOrPubkey);

        [Syscall("Quras.Runtime.Notify")]
        public static extern void Notify(params object[] state);

        [Syscall("Quras.Runtime.Log")]
        public static extern void Log(string message);
    }
}
