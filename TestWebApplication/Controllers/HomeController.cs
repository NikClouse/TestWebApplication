using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestWebApplication.Models;

namespace TestWebApplication.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			Test model = new Test
			{
				LinkText = "Запустить",
				ExecutablePath = "notepad.exe"
			};
			return View(model);
		}

		// Событие onClick для гиперссылки
		public IActionResult RunExecutable(string executablePath)
		{
			Process.Start(executablePath);
			return RedirectToAction("Index");
		}





	}
}
