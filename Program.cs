using BenchmarkDotNet.Running;

namespace BenchmarkMapping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkTests.MappingBenchmark>();
        }
    }
}
