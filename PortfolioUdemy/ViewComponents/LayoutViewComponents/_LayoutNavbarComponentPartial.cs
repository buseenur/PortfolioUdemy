using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;

namespace PortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		private readonly PortfolioContext _context;

		public _LayoutNavbarComponentPartial(PortfolioContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = _context.ToDoLists.Where(x=>x.Status==false).Count();
			//ViewBag.v2 = _context.ToDoLists.Where(x => x.Status == false).ToList();
			var value = _context.ToDoLists.Where(x => x.Status == false).ToList();
			return View(value);
		}
	}
}
