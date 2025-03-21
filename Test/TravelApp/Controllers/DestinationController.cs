using Microsoft.AspNetCore.Mvc;
using TravelApp.Models; // Destination modelini içeri aktaralım

namespace TravelApp.Controllers
{
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            // Destination modelini bir List ile başlatıyoruz
            var destinations = new List<Destination>
            {
                new Destination { Id = 1, Name = "Paris", Description = "Aşkın şehri.", ImageUrl = "/images/paris.jpg", Price = 1200.00 },
                new Destination { Id = 2, Name = "New York", Description = "Işıkları hiç sönmeyen şehir.", ImageUrl = "/images/nyc.jpg", Price = 1500.00 },
                new Destination { Id = 3, Name = "Tokyo", Description = "Modernizm ve gelenekselliğin muhteşem karışımı.", ImageUrl = "/images/tokyo.jpg", Price = 1800.00 },
                new Destination { Id = 4, Name = "Kapadokya", Description = "Bir doğa mucizesi", ImageUrl = "/images/kapadokya.jpg", Price = 1000.00},
                new Destination { Id = 5, Name = "Roma", Description = "Zamana meydan okuyan ihtişam", ImageUrl = "/images/roma.jpg", Price = 1350.00},
                new Destination { Id = 6, Name = "Giza", Description = "Mısır'ın gizemli geçmişine yolculuk", ImageUrl = "/images/gyza.jpg", Price = 1050.00}

            };

            return View(destinations); // List<Destination> türünde bir koleksiyon gönderiyoruz
        }
    }
}
