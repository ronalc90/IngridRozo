namespace CarRental.Models
{
    public class Rental
    {
        public string Id { get; set; } = "";
        public int IdCar { get; set; }
        public string Latitudetart { get; set; } = "";
        public string LongitudeStart { get; set; } = "";
        public string LatitudeEnd { get; set; } = "";
        public string LongitudeEnd { get; set; } = "";
        public DateTime Start { get; set; } 
        public DateTime? End { get; set; }

        public Vehicle Vehicle { get; set; } = new Vehicle();
        public Client Client { get; set; } = new Client();



    }
}
