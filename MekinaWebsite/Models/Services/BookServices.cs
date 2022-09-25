using System.Collections.Generic;
using System.Linq;

namespace MekinaWebsite.Models.Services
{
    public class BookServices : IBookServices
    {
        private readonly MekinaDBContext _context;

        public BookServices(MekinaDBContext context)
        {
            _context = context;
        }

        public List<BookingModel> GetList()
        {

            var bookings = _context.bookingList.ToList();
            return bookings;
        }

        public void Add(BookingModel bookingModel)
        {
            _context.Add(bookingModel);
            _context.SaveChanges();
        }

        public BookingModel GetById(long id)
        {
            var result = _context.bookingList.Find(id);
            return result;
        }

    }
}
