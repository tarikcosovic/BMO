namespace BMO.Api.Models
{
    public class Player
    {
        public int Id { get; set; }
        public Guid DeviceId { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;

        //navigation properties
        public List<Score> Scores { get; set; }
        public Device Device { get; set; }

        public Player() { }

        public Player(int id, Guid deviceId, string username)
        {
            Id = id;
            DeviceId = deviceId;
            Username = username;
        }
    }
}
