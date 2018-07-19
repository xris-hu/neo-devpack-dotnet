namespace Ont.SmartContract.Framework.Services.Ont
{
    public class Native
    {

        [Syscall("Ontology.Native.Invoke")]
        public static extern byte[] Invoke(int version, byte[] address, string method, object args);

    }
}
