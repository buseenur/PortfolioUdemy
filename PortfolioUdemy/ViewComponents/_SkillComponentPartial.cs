using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;

namespace PortfolioUdemy.ViewComponents
{	
	public class _SkillComponentPartial:ViewComponent
	{PortfolioContext portfolioContext = new PortfolioContext();

		public IViewComponentResult Invoke()
		{
			var values = portfolioContext.Skills.ToList();
			return View(values);
		}
	}
}
