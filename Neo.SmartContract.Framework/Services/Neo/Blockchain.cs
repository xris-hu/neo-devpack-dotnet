namespace Neo.SmartContract.Framework.Services.Neo
{
    public static class Blockchain
    {
        [Syscall("System.Blockchain.GetHeight")]
        public static extern uint GetHeight();

        [Syscall("System.Blockchain.GetHeader")]
        public static extern Header GetHeader(uint height);

        [Syscall("System.Blockchain.GetHeader")]
        public static extern Header GetHeader(byte[] hash);

        [Syscall("System.Blockchain.GetBlock")]
        public static extern Block GetBlock(uint height);

        [Syscall("System.Blockchain.GetBlock")]
        public static extern Block GetBlock(byte[] hash);

        [Syscall("System.Blockchain.GetTransaction")]
        public static extern Transaction GetTransaction(byte[] hash);

        [Syscall("Neo.Blockchain.GetAccount")]
        public static extern Account GetAccount(byte[] script_hash);

        [Syscall("Neo.Blockchain.GetValidators")]
        public static extern byte[][] GetValidators();

        [Syscall("Neo.Blockchain.GetAsset")]
        public static extern Asset GetAsset(byte[] asset_id);

        [Syscall("System.Blockchain.GetContract")]
        public static extern Contract GetContract(byte[] script_hash);

        [Syscall("System.Blockchain.GetTransactionHeight")]
        public static extern uint GetTransactionHeight(byte[] script_hash);
    }
}
