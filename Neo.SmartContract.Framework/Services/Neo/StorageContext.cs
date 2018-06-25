namespace Neo.SmartContract.Framework.Services.Neo
{
    public class StorageContext
    {
        [Syscall("System.StorageContext.AsReadOnly")]
        public static extern void AsReadOnly(StorageContext context);
    }
}
