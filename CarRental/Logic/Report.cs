using CarRental.DataAcces;
using CarRental.Models;

namespace CarRental.Logic
{
    public class Report
    {
        public IRepository repository;
        public Report(IRepository Repository) 
        {
            repository = Repository;
        } 

        public List<Vehicle> Availables() => repository.Vehicle().Where(v => v.Available).ToList();



    }
}
