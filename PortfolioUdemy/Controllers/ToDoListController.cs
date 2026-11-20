using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;
using PortfolioUdemy.DAL.Entities;

namespace PortfolioUdemy.Controllers
{
	public class ToDoListController : Controller
	{
		private readonly PortfolioContext _context;

		public ToDoListController(PortfolioContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var values = _context.ToDoLists.ToList();
			return View(values);
		}
		public IActionResult DeleteToDo(int id) 
		{
			var value = _context.ToDoLists.Find(id);
			_context.ToDoLists.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("Index");

		}
		[HttpGet]
		public IActionResult CreateToDo()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateToDo(ToDoList toDo)
		{
			toDo.Status = false;
			var value = _context.ToDoLists.Add(toDo);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult UpdateToDo(int id)
		{
			var value = _context.ToDoLists.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateToDo(ToDoList toDo)
		{
			_context.ToDoLists.Update(toDo);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeIsReadTrue(int id)
		{
			var value = _context.ToDoLists.Find(id);
			value.Status = true;
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeIsReadFalse(int id)
		{
			var value = _context.ToDoLists.Find(id);
			value.Status = false;
			_context.SaveChanges();
			return RedirectToAction("Index");

		}
	}
}
