using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;
using System.ComponentModel;

namespace PortfolioUdemy.ViewComponents
{
	public class _ExperienceComponentPartial:ViewComponent
	{
		PortfolioContext portfolioContext = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Experiences.ToList();
			return View(values);
		}
	}
}
