namespace Ont.SmartContract.Framework.Services.Ont
{
    public class TransactionInput : IApiInterface
    {
        public extern byte[] PrevHash
        {
            [Syscall("Neo.Input.GetHash")]
            get;
        }

        public extern ushort PrevIndex
        {
            [Syscall("Neo.Input.GetIndex")]
            get;
        }
    }
}
