using AutoMapper;

namespace automapper.src;
public class BaseDestinationEntityProfile : Profile
{
    public BaseDestinationEntityProfile()
    {
        CreateMap<SourceEntity, BaseDestinationEntity>()
            .ForMember(dest => dest.Id, otp => otp.MapFrom(src => src.Id2))
            .ForMember(dest => dest.Name, otp => otp.MapFrom(src => src.Name2));
    }
}