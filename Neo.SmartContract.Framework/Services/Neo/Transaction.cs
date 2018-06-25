namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Transaction : IScriptContainer
    {
        public extern byte[] Hash
        {
            [Syscall("System.Transaction.GetHash")]
            get;
        }

        public extern byte Type
        {
            [Syscall("Ontology.Transaction.GetType")]
            get;
        }

        [Syscall("Ontology.Transaction.GetAttributes")]
        public extern TransactionAttribute[] GetAttributes();

        [Syscall("Neo.Transaction.GetInputs")]
        public extern TransactionInput[] GetInputs();

        [Syscall("Neo.Transaction.GetOutputs")]
        public extern TransactionOutput[] GetOutputs();

        [Syscall("Neo.Transaction.GetReferences")]
        public extern TransactionOutput[] GetReferences();

        [Syscall("Neo.Transaction.GetUnspentCoins")]
        public extern TransactionOutput[] GetUnspentCoins();
    }
}
