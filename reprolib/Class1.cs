using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace reprolib
{
    public class Reprolib
    {
        [UnmanagedCallersOnly(EntryPoint = "addNumber", CallConvs = new[] { typeof(CallConvCdecl) })]
        public static int AddNumber(int a, int b)
        {
            return a + b;
        }
    }
}