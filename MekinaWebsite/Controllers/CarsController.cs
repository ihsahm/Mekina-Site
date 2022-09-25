using MekinaWebsite.Models;
using MekinaWebsite.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MekinaWebsite.Controllers
{

    [Authorize]
    public class CarsController : Controller
    {
        private MekinaDBContext _context;
        private readonly ICarServices _carServices;
        private readonly IBookServices _bookServices;

        public CarsController(ICarServices carServices, IBookServices bookServices, MekinaDBContext context)
        {
            _carServices = carServices;
            _bookServices = bookServices;
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var carData = _carServices.GetCarsList();
            return View(carData);
        }
        [AllowAnonymous]
        public IActionResult Details(long id)
        {
            var carData = _carServices.GetById(id);
            if (carData == null) return View("Car data not found");
            return View(carData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarsList carsList)
        {
            _carServices.Add(carsList);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(long id)
        {
            var data = _context.carLists.Where(temp => temp.CarId == id).FirstOrDefault();
            if (data == null) return View("NotFound");
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(long id, CarsList carsList)
        {
            var updateData = _carServices.GetById(id);
            updateData.Price = carsList.Price;
            updateData.PhoneNumber = carsList.PhoneNumber;
            updateData.CarName = carsList.CarName;
            updateData.CarStatus = carsList.CarStatus;
            updateData.CarYear = carsList.CarYear;
            updateData.Mileage = carsList.Mileage;
            updateData.CarImage = carsList.CarImage;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(long id)
        {
            var data = _carServices.GetById(id);
            if (data == null) return View("NotFound");
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(long id)
        {
            var data = _carServices.GetById(id);
            if (data == null) return View("NotFound");
            _carServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        public ActionResult Search(string searchString)
        {
            var cars = _carServices.GetCarsList();
            List<CarsList> filteredCars = _carServices.GetCarsList();
            if (!string.IsNullOrEmpty(searchString))
            {
                filteredCars = cars.Where(temp => temp.CarName.Contains(searchString)).ToList();
            }
            ViewBag.filteredCars = filteredCars;
            return View();
        }
        public IActionResult BookList()
        {
            var bookData = _bookServices.GetList();
            return View(bookData);
        }
        public ActionResult Book(long Id)
        {
            BookingModel bookings = new BookingModel();
            var bookCars = _context.carLists.Where(a => a.CarId == Id).FirstOrDefault();
            bookings.BookedCarId = Id;
            bookings.BookedCarName = bookCars.CarName;
            return View(bookings);
        }
        [HttpPost]
        public ActionResult Book(BookingModel bookingModel, int Id)
        {

            var bookCars = _context.carLists.Where(a => a.CarId == Id).FirstOrDefault();
            bookingModel.BookedCarName = bookCars.CarName;
            _context.Add(bookingModel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
