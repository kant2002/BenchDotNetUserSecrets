using BenchmarkDotNet.Running;

namespace BenchDotNetUserSecrets
{
    class Program
    {
        internal static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
