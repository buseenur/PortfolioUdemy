using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;

namespace PortfolioUdemy.ViewComponents
{
	public class _FeatureComponentPartial : ViewComponent
	{
		PortfolioContext portfolioContext = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Features.ToList();
			return View(values);
		}
	}
}
