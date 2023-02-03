using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace reprolib
{
    public class Reprolib
    {
        [UnmanagedCallersOnly(EntryPoint = "addNumber")]
        public static int AddNumber(int a, int b)
        {
            return a + b;
        }
    }
}