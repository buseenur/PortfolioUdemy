using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents
{
	public class _PortfolioComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
