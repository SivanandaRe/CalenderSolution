using CalenderBL;
using CalenderBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalenderUI.Controllers
{
    public class CalenderController : Controller
    {
        CalenderBussinessLogic cbl = new CalenderBussinessLogic();

        // GET: Calender
        public ActionResult Index()
        {
           List<CalenderModel> calenderList = cbl.GetCalenderData();
           return View(calenderList);
        }
    }
}