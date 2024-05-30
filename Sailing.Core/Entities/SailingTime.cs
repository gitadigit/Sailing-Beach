namespace SAILING_BEACH
{
    public class SailingTime
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Boat Boat { get; set; }

        public BoatDriver BoatDriver { get; set; }

    }
}
