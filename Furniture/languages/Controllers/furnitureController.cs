using languages.Models;
using Microsoft.AspNetCore.Mvc;


namespace languages.Controllers
{
	public class furnitureController : Controller
	{
		Entities Entities;
        public furnitureController(Entities entities)
        {
			Entities = entities;
            
        }
		[HttpGet]
		public IActionResult New()
		{
			return View();
		}
		[HttpPost]
		public IActionResult New(furniture furniture)
		{
			Entities.furnitures.Add(furniture);
			Entities.SaveChanges();
			return RedirectToAction("Index", "Home");
			
		}
		[HttpGet]
		public IActionResult Edit(int id) {
			var fun=Entities.furnitures.FirstOrDefault(i=> i.Id==id);
			return View(fun);
		}
		public IActionResult Edit(furniture newfun,int id) {
            if (newfun.Name !=null)
            {
                var oldfun = Entities.furnitures.FirstOrDefault(x => x.Id == id);
                oldfun.Name = newfun.Name;
                oldfun.Description = newfun.Description;
                oldfun.image = newfun.image;
                Entities.SaveChanges();
				return RedirectToAction("Index", "Home");
            }
            
			return View(newfun);
		}
        public IActionResult Delete(int id)
        {
            var product = Entities.furnitures.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
        public IActionResult ConfirmDelete(int id)
		{
			var fun=Entities.furnitures.FirstOrDefault(x=> x.Id==id);
			Entities.furnitures.Remove(fun);
			Entities.SaveChanges();
			return RedirectToAction("Index", "Home");
		}
		

	}
}
