using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents
{
	public class _StatisticComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
