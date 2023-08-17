namespace BMO.Api.Models.Requests
{
    public class CreatePlayerRequest
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Username { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
