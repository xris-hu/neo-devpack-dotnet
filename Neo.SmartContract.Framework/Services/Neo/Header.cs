namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Header : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("System.Header.GetHash")]
            get;
        }

        public extern uint Version
        {
            [Syscall("Neo.Header.GetVersion")]
            get;
        }

        public extern byte[] PrevHash
        {
            [Syscall("System.Header.GetPrevHash")]
            get;
        }

        public extern byte[] MerkleRoot
        {
            [Syscall("Ontology.Header.GetMerkleRoot")]
            get;
        }

        public extern uint Timestamp
        {
            [Syscall("System.Header.GetTimestamp")]
            get;
        }

        public extern uint Index
        {
            [Syscall("System.Header.GetIndex")]
            get;
        }

        public extern ulong ConsensusData
        {
            [Syscall("Ontology.Header.GetConsensusData")]
            get;
        }

        public extern byte[] NextConsensus
        {
            [Syscall("Ontology.Header.GetNextConsensus")]
            get;
        }
    }
}
