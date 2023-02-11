using Microsoft.Extensions.Hosting;

namespace BMO.Api.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;

        //Navigation properties
        public List<Score> Scores{ get; set; }

    }
}
