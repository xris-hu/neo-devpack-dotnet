namespace Ont.SmartContract.Framework.Services.Ont
{
    public class InvocationTransaction : Transaction
    {
        public extern byte[] Script
        {
            [Syscall("Neo.InvocationTransaction.GetScript")]
            get;
        }
    }
}
