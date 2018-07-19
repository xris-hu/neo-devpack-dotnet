namespace Ont.SmartContract.Framework.Services.Ont
{
    public class Account
    {
        public extern byte[] ScriptHash
        {
            [Syscall("Neo.Account.GetScriptHash")]
            get;
        }

        public extern byte[][] Votes
        {
            [Syscall("Neo.Account.GetVotes")]
            get;
        }

        [Syscall("Neo.Account.GetBalance")]
        public extern long GetBalance(byte[] asset_id);
    }
}
