namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Native
    {

        [Syscall("Ontology.Native.Invoke")]
        public static extern object Invoke(int version, byte[] address, string method, object[] args);

    }
}
