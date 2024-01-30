namespace SAILING_BEACH
{
    public class Boat
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string YearOfManufacture { get; set; }

        public int NumberOfPassenger { get; set; }

        public bool AfterSunset { get; set; }

        public List<BoatDriver> Drivers { get; set; } //רבים לרבים 

    }
}
