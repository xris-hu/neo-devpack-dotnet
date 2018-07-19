namespace Ont.SmartContract.Framework.Services.Ont
{
    public class StorageContext
    {
        [Syscall("System.StorageContext.AsReadOnly")]
        public static extern void AsReadOnly(StorageContext context);
    }
}
