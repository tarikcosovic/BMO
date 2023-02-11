using AutoMapper;
using BMO.Api.Models;
using BMO.Api.Models.Requests;
using Microsoft.EntityFrameworkCore;

namespace BMO.Api.Repositories
{
    public class GameRepository : GenericRepository<Game>
    {
        public GameRepository(BmodbContext dbContext) : base(dbContext)
        {

        }
    }
}
