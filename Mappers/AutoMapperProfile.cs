using AutoMapper;
using BenchmarkMapping.Models;

namespace BenchmarkMapping.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SourceClass, DestinationClass>()
                .ForMember(dest => dest.ExtraInfo, opt => opt.Ignore());
        }
    }
}
