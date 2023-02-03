using MemoryModule;
using System.Runtime.InteropServices;

namespace repro
{
    internal class Program
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        delegate int addNumberProc(int a, int b);
        static void Main(string[] args)
        {
            var asmBytes = File.ReadAllBytes(@"C:\Users\mrzax\source\repos\MemoryModule.NET-repro\reprolib\bin\Release\net7.0\publish\win-x64\reprolib.dll");

            var asm = NativeAssembly.Load(asmBytes);
            Console.WriteLine("Successfully loaded library.");
            var addNumberFunc = asm.GetDelegate<addNumberProc>("addNumber");
            var rand = new Random();
            int num1 = rand.Next(0, 20);
            int num2 = rand.Next(0, 20);
            var result = addNumberFunc(num1, num2);
            Console.WriteLine($"{num1}+{num2}={result}");
            asm.Dispose();
            Console.ReadLine();
        }
    }
}