using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;

namespace BMO.Api.Mappings
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<CreatePlayerRequest, Player>().ReverseMap();
        }
    }
}
