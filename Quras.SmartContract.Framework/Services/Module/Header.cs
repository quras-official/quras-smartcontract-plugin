namespace Quras.SmartContract.Framework.Services.Module
{
    public class Header : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("Quras.Header.GetHash")]
            get;
        }

        public extern uint Version
        {
            [Syscall("Quras.Header.GetVersion")]
            get;
        }

        public extern byte[] PrevHash
        {
            [Syscall("Quras.Header.GetPrevHash")]
            get;
        }

        public extern byte[] MerkleRoot
        {
            [Syscall("Quras.Header.GetMerkleRoot")]
            get;
        }

        public extern uint Timestamp
        {
            [Syscall("Quras.Header.GetTimestamp")]
            get;
        }

        public extern uint Index
        {
            [Syscall("Quras.Header.GetIndex")]
            get;
        }

        public extern ulong ConsensusData
        {
            [Syscall("Quras.Header.GetConsensusData")]
            get;
        }

        public extern byte[] NextConsensus
        {
            [Syscall("Quras.Header.GetNextConsensus")]
            get;
        }
    }
}
