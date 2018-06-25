namespace Neo.SmartContract.Framework.Services.Neo
{
    public class TransactionAttribute : IApiInterface
    {
        public extern byte Usage
        {
            [Syscall("Ontology.Attribute.GetUsage")]
            get;
        }

        public extern byte[] Data
        {
            [Syscall("Ontology.Attribute.GetData")]
            get;
        }
    }
}
