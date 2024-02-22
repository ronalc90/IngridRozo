using CarRental.Models;
using System.Collections.Generic;

namespace CarRental.DataAcces
{
    public interface IRepository
    {
        public List<Vehicle> Vehicle();
        public List<Client> Client();
        public List<Rental> Rental();
    }

    public class Repository : IRepository
    {
        public List<Client> Client()  => new List<Client>();
        public List<Rental> Rental() => new List<Rental>();
        public List<Vehicle> Vehicle()  => new List<Vehicle>();
        

    }
}
