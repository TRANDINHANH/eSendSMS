using eSendSMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eSendSMS.Controllers
{
    public class ActivitiesController : Controller
    {
        private readonly ILogger<ActivitiesController> _logger;

        public ActivitiesController(ILogger<ActivitiesController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult QuanLyDanhBa()
        {
            return View();
        }
        public IActionResult GuiTinNhan()
        {
            return View();
        }
        public IActionResult PhanNhom()
        {
            return View();
        }
        public IActionResult QuanLyNhom()
        {
            return View();
        }
        public IActionResult ThongKeChiTietTinNhan()
        {
            return View();
        }
		public IActionResult DoiMatKhau()
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
