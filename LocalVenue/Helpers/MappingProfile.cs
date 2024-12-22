using AutoMapper;
using LocalVenue.Core.Entities;
using LocalVenue.RequestDTOs;

namespace LocalVenue.Helpers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TicketRequestDTO, Ticket>()
            .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => 0));

        CreateMap<ShowRequestDTO, Show>()
            .ForMember(dest => dest.ShowId, opt => opt.MapFrom(src => 0));
    }
}