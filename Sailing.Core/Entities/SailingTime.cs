namespace SAILING_BEACH
{
    public class SailingTime
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public List<BoatDriver> BoatDrivers { get; set; }//יחד לרבים 
    }
}
