namespace BMO.Api.Models.Requests
{
    public class CreateGameRequest
    {
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
