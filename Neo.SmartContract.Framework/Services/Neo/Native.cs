namespace Neo.SmartContract.Framework.Services.Neo
{
    public class Native
    {

        [Syscall("Ontology.Native.Invoke")]
        public static extern object Invoke(int version, byte[] address, byte[] method, object[] args);

    }
}
