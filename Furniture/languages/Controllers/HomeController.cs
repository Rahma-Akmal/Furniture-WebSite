using System.Diagnostics;
using languages.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace languages.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		Entities entities;


		public HomeController(ILogger<HomeController> logger,Entities entities)
		{
			_logger = logger;
			this.entities = entities;
		}
		public ActionResult Details(int Id) {

			var mov=entities.furnitures.FirstOrDefault(x => x.Id == Id);
			return View(mov);
		}
		
		public IActionResult Index()
		{
			var funs=entities.furnitures.ToList();
			return View(funs);
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
