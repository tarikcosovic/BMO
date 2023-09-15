using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;

namespace BMO.Api.Mappings
{
    public class ScoreProfile : Profile
    {
        public ScoreProfile() => CreateMap<CreateScoreRequest, Score>().ReverseMap();
    }
}
