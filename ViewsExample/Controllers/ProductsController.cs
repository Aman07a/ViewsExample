using Microsoft.AspNetCore.Mvc;

namespace ViewsExample.Controllers
{
	public class ProductsController : Controller
	{
		[Route("products/all")]
		public IActionResult All()
		{
			// Views/Products/All.cshtml
			// Views/Shared/All.cshtml
			return View();
		}
	}
}
