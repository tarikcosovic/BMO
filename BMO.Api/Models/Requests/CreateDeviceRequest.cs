namespace BMO.Api.Models.Requests
{
    public class CreateDeviceRequest
    {
        public string ProductionModel { get; set; } = string.Empty;
        public string SoftwareVersion { get; set; } = string.Empty;
        public bool Warranty { get; set; } = false;
    }
}
