using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutFooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
