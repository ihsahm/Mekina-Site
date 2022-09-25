using System.Collections.Generic;
using System.Linq;

namespace MekinaWebsite.Models.Services
{
    public class CarServices : ICarServices
    {
        private readonly MekinaDBContext _context;
        public CarServices(MekinaDBContext context)
        {
            _context = context;
        }
        public void Add(CarsList carsList)
        {
            _context.carLists.Add(carsList);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {

            var cars = _context.carLists.Find(id);
            _context.Remove(cars);
            _context.SaveChanges();
        }

        public List<CarsList> GetCarsList()
        {
            var items = _context.carLists.
                ToList();
            return items;
        }

        public CarsList GetById(long id)
        {
            var result = _context.carLists.Find(id);

            return result;
        }

        public CarsList Update(long id, CarsList carsList)
        {
            _context.Update(carsList);
            _context.SaveChanges();
            return carsList;
        }

    }
}
