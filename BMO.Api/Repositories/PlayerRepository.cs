using BMO.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BMO.Api.Repositories
{
    public class PlayerRepository : GenericRepository<Player>
    {
        public PlayerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
