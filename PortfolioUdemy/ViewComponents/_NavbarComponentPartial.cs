using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents
{
	public class _NavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View();
		}
	}
}
