using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using AutoMapper;
using BenchmarkMapping.Models;
using BenchmarkMapping.Mappers;

namespace BenchmarkMapping.BenchmarkTests
{
    [MemoryDiagnoser] 
    [HardwareCounters]
    public class MappingBenchmark
    {
        private List<SourceClass> _sources = default!;
        private IMapper _autoMapper = default!;

        [GlobalSetup]
        public void Setup()
        {
            _sources = DataGenerator.GenerateSources(100_000);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            _autoMapper = config.CreateMapper();
        }

        [Benchmark(Description = "Riok Mapperly")]
        public List<DestinationClass> MapWithMapperly()
        {
            var result = new List<DestinationClass>(_sources.Count);
            foreach (var source in _sources)
            {
                var mapped = RiokMapperly.Map(source);
                result.Add(mapped);
            }
            return result;
        }

        [Benchmark(Description = "AutoMapper")]
        public List<DestinationClass> MapWithAutoMapper()
        {
            return _autoMapper.Map<List<DestinationClass>>(_sources);
        }
    }
}
