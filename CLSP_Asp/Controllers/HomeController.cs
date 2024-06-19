using CLSP_Asp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CLSP_Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var cidades = new List<Cidade>
            {
            new Cidade { Name = "Ubatuba", ImagePath = "/images/ubatuba.jpg", NivelDeRisco = "Alto" },
            new Cidade { Name = "São Sebastião", ImagePath = "/images/sao-sebastiao.jpg", NivelDeRisco = "Alto" },
            new Cidade { Name = "Ilha Comprida", ImagePath = "/images/ilha-comprida.jpg", NivelDeRisco = "Alto" }
            };

            return View(cidades);
        }

        public IActionResult Erosion()
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
