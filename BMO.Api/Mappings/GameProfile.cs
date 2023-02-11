using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;

namespace BMO.Api.Mappings
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game, CreateGameRequest>().ReverseMap();
        }
    }
}
