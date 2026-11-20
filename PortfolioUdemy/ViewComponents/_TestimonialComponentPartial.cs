using Microsoft.AspNetCore.Mvc;

namespace PortfolioUdemy.ViewComponents
{
	public class _TestimonialComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
