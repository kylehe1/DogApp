using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Hello()
        {
            DogViewModel doggy = new DogViewModel()
            {
                Name = "HELLO!",
                Age = 2
            };
            return View(doggy);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult HotelBookingDetails()
        {
            HotelBooking booking = new HotelBooking()
            {
                Id = 10,
                GuestName = "Kyle Heneghen",
                CheckIn = DateTime.Now,
                CheckOut = DateTime.Now.AddDays(300),
            };
            return View(booking);
        }

        public IActionResult Index()
        {
            //DogViewModel doggo = new DogViewModel() 
            //{ 
            //    Name="Sif", 
            //    Age=2
            //};
            //return View(doggo);
            return View(dogs);
        }
    }
}
