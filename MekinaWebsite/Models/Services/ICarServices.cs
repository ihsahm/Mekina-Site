using System.Collections.Generic;

namespace MekinaWebsite.Models.Services
{
    public interface ICarServices
    {
        List<CarsList> GetCarsList();
        void Add(CarsList carsList);
        CarsList GetById(long id);
        void Delete(long id);
        CarsList Update(long id, CarsList update);
    }
}