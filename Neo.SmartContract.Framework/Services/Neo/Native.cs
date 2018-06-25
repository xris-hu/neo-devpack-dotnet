namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Native
    {

        [Syscall("Ontology.Native.Invoke")]
        public static extern byte[] Invoke(int version, byte[] address, string method, object args);

    }
}
