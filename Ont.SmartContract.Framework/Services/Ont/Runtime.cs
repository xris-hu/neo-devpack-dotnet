namespace Ont.SmartContract.Framework.Services.Ont
{
    public static class Runtime
    {
        public static extern TriggerType Trigger
        {
            [Syscall("Neo.Runtime.GetTrigger")]
            get;
        }

        public static extern uint Time
        {
            [Syscall("System.Runtime.GetTime")]
            get;
        }

        [Syscall("System.Runtime.CheckWitness")]
        public static extern bool CheckWitness(byte[] hashOrPubkey);

        [Syscall("System.Runtime.Notify")]
        public static extern void Notify(params object[] state);

        [Syscall("System.Runtime.Log")]
        public static extern void Log(string message);

        [Syscall("Ontology.Runtime.Base58ToAddress")]
        public static extern byte[] Base58ToAddress(string base58);

        [Syscall("Ontology.Runtime.AddressToBase58")]
        public static extern string AddressToBase58(byte[] address);

        [Syscall("Ontology.Runtime.GetCurrentBlockHash")]
        public static extern byte[] GetCurrentBlockHash();
    }
}
