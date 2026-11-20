using Microsoft.AspNetCore.Mvc;
using PortfolioUdemy.DAL.Context;
using PortfolioUdemy.DAL.Entities;

namespace PortfolioUdemy.Controllers
{
	public class ExperienceController : Controller
	{
		private readonly PortfolioContext _context;

		public ExperienceController(PortfolioContext context)
		{
			_context = context;
		}

		public IActionResult ExperienceList()
		{
			var values = _context.Experiences.ToList();
			return View(values);
		}
		public IActionResult DeleteExperience(int id)
		{
			var values = _context.Experiences.Find(id);
			_context.Experiences.Remove(values);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = _context.Experiences.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			_context.Experiences.Update(experience);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}
	
		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			_context.Experiences.Add(experience);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
