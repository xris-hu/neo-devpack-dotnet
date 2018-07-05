namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Contract
    {
        public extern byte[] Script
        {
            [Syscall("Ontology.Contract.GetScript")]
            get;
        }
       
        public extern bool IsPayable
        {
            [Syscall("Neo.Contract.IsPayable")]
            get;
        }

        public extern StorageContext StorageContext
        {
            [Syscall("System.Contract.GetStorageContext")]
            get;
        }

        [Syscall("Ontology.Contract.Create")]
        //public static extern Contract Create(byte[] script, byte[] parameter_list, byte return_type, bool need_storage, string name, string version, string author, string email, string description);
        public static extern Contract Create(byte[] script, bool need_storage, string name, string version, string author, string email, string description);

        [Syscall("Ontology.Contract.Migrate")]
        //public static extern Contract Migrate(byte[] script, byte[] parameter_list, byte return_type, bool need_storage, string name, string version, string author, string email, string description);
        public static extern Contract Migrate(byte[] script, bool need_storage, string name, string version, string author, string email, string description);

        [Syscall("System.Contract.Destroy")]
        public static extern void Destroy();
    }
}
