using Riok.Mapperly.Abstractions;
using BenchmarkMapping.Models;

namespace BenchmarkMapping.Mappers
{
    [Mapper] 
    public static partial class RiokMapperly
    {
        public static partial DestinationClass Map(SourceClass source);
    }
}
