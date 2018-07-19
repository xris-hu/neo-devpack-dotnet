namespace Ont.SmartContract.Framework.Services.Ont
{
    public class Block : Header
    {
        [Syscall("System.Block.GetTransactionCount")]
        public extern int GetTransactionCount();

        [Syscall("System.Block.GetTransactions")]
        public extern Transaction[] GetTransactions();

        [Syscall("System.Block.GetTransaction")]
        public extern Transaction GetTransaction(int index);
    }
}
