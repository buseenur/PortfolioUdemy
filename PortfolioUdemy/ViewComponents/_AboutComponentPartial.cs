using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;

namespace PortfolioUdemy.ViewComponents
{
	public class _AboutComponentPartial:ViewComponent
	{
		PortfolioContext portfolioContext = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			//var values = portfolioContext.Abouts.ToList();
			ViewBag.aboutTitle = portfolioContext.Abouts.Select(a => a.Title).FirstOrDefault();
			ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
			ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
			return View();
		}
	}
}
