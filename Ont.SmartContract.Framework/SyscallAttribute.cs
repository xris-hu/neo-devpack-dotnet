using System;

namespace Ont.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class SyscallAttribute : Attribute
    {
        public string Method { get; }

        public SyscallAttribute(string method)
        {
            this.Method = method;
        }
    }
}
