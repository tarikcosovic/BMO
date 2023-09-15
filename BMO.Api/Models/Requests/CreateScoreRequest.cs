namespace BMO.Api.Models.Requests
{
    public class CreateScoreRequest
    {
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public int Value { get; set; }
    }
}
