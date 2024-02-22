namespace CarRental.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Registration { get; set; } = "";
        public string Vim { get; set; } = "";
        public string Band { get; set; } = "";
        public DateTime Manufactured { get; set; }
        public string Latitude { get; set; } = "";
        public string Longitude { get; set; } = "";
        public bool Available { get; set; }
        public List<Rental> Rentals { get; set; } = new List<Rental>();

    }
}
