namespace CarRental.Models
{
    public class Client
    {
        public string Id { get; set; } = "";
        public string Names { get; set; } = "";
        public string Surnames { get; set; } = "";
        public DateTime Birh { get; set; }
        public string Country { get; set; } = "";
        public List<Rental> Rentals { get; set; } = new List<Rental>();

    }
}
