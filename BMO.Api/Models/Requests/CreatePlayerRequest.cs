namespace BMO.Api.Models.Requests
{
    public class CreatePlayerRequest
    {
        //The deviceId of the players' device
        public string Username { get; set; }
        public Guid DeviceId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
