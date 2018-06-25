using System.Numerics;

namespace Neo.SmartContract.Framework.Services.Neo
{
    public static class Storage
    {
        public static extern StorageContext CurrentContext
        {
            [Syscall("System.Storage.GetContext")]
            get;
        }

        [Syscall("System.Storage.Get")]
        public static extern byte[] Get(StorageContext context, byte[] key);

        [Syscall("System.Storage.Get")]
        public static extern byte[] Get(StorageContext context, string key);

        [Syscall("System.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, byte[] value);

        [Syscall("System.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, BigInteger value);

        [Syscall("System.Storage.Put")]
        public static extern void Put(StorageContext context, byte[] key, string value);

        [Syscall("System.Storage.Put")]
        public static extern void Put(StorageContext context, string key, byte[] value);

        [Syscall("System.Storage.Put")]
        public static extern void Put(StorageContext context, string key, BigInteger value);

        [Syscall("System.Storage.Put")]
        public static extern void Put(StorageContext context, string key, string value);

        [Syscall("System.Storage.Delete")]
        public static extern void Delete(StorageContext context, byte[] key);

        [Syscall("System.Storage.Delete")]
        public static extern void Delete(StorageContext context, string key);

        [Syscall("Neo.Storage.Find")]
        public static extern Iterator<byte[], byte[]> Find(StorageContext context, byte[] prefix);

        [Syscall("Neo.Storage.Find")]
        public static extern Iterator<string, byte[]> Find(StorageContext context, string prefix);

        [Syscall("System.Storage.GetReadOnlyContext")]
        public static extern void GetReadOnlyContext();
    }
}
