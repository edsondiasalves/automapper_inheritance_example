using AutoMapper;

namespace automapper.src;
public class DestinationEntityProfile : Profile
{
    public DestinationEntityProfile()
    {
        CreateMap<SourceEntity, DestinationEntity>()
            .IncludeBase<SourceEntity, BaseDestinationEntity>()
            .ForMember(dest => dest.Age, otp => otp.MapFrom(src => src.Age2));
    }
}