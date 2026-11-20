using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents
{
	public class _HeadComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
