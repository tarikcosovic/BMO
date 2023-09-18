namespace BMO.Api.Models
{
    public class Device
    {
        public Guid Id { get; set; }
        public string ProductionModel { get; set; } = string.Empty;
        public string SoftwareVersion { get; set; } = string.Empty;
        public bool Warranty { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;

        //navigation properties
        public List<Player> Players { get; set; }

        public Device()
        {

        }

        public Device(Guid id, string productionModel, string softwareVersion, bool warranty)
        {
            Id = id;
            ProductionModel = productionModel;
            SoftwareVersion = softwareVersion;
            Warranty = warranty;
        }
    }
}
