using eSendSMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eSendSMS.Controllers
{
	public class LoginController1 : Controller
	{
		private readonly ILogger<LoginController1> _logger;

		public LoginController1(ILogger<LoginController1> logger)
		{
			_logger = logger;
		}

		public IActionResult Login()
		{
			return View();
		}
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
