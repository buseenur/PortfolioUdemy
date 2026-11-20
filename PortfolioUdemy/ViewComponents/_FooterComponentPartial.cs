using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents
{
	public class _FooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
