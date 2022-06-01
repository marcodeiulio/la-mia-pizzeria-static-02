using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //2. Creare una funzione che stampa la somma dei numeri che vanno da 1 a n(con n passato come parametro - n incluso)
        //Stampare dentro uno span il risultato.
        public int SommaNum(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }

        

        public IActionResult Index()
        {
            int sum = SommaNum(10);
            
            return View(sum);
        }

        public IActionResult Description()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}