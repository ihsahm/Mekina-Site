using System.Collections.Generic;

namespace MekinaWebsite.Models.Services
{
    public interface IBookServices
    {
        List<BookingModel> GetList();
        void Add(BookingModel bookingModel);
        BookingModel GetById(long id);

    }
}
