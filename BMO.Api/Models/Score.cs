using Microsoft.Extensions.Hosting;

namespace BMO.Api.Models
{
    public class Score
    {
        public int Value { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public int GameId { get; set; }
        public Game Game{ get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
