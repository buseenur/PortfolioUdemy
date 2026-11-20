using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;
using PortfolioUdemy.DAL.Entities;

namespace PortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		private readonly PortfolioContext _context;

		public MessageController(PortfolioContext context)
		{
			_context = context;
		}

		public IActionResult Inbox()
		{
			var values = _context.Messages.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = _context.Messages.Find(id);
			value.IsRead = true;
			_context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadFalse(int id)
		{
			var value = _context.Messages.Find(id);
			value.IsRead = false;
			_context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public ActionResult DeleteMessage(int id) 
		{
			var value = _context.Messages.Find(id);
			_context.Messages.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult MessageDetail(int id)
		{
			var value = _context.Messages.Find(id);
			return View(value);
		}
	}
}
