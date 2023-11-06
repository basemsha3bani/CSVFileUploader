using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSVFileUploader.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(MenuDisplayViewModel menuDisplayModel)
        {
            return View(menuDisplayModel);
        }

        [HttpPost]
        public IActionResult Search(MenuDisplayViewModel searchModel)
        {
            /*For simplicity this is a dummy list for test*/
            List<MenuItemViewModel> menuItems = new List<MenuItemViewModel>
        {
           new MenuItemViewModel{Action="Index",Controller="Teacher",LinkText="TeacherController",userType=UserType.Teacher},
           new MenuItemViewModel{Action="Index",Controller="Student",LinkText="StudentController",userType=UserType.Student},
        };

            searchModel.menuItems = menuItems.Where(w => w.userType== searchModel.userType).ToList();

            return View("Index", searchModel);
        }

    }
}