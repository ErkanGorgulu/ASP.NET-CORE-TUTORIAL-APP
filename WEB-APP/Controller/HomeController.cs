using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEB_APP.Controller
{
    public class HomeController: Microsoft.AspNetCore.Mvc.Controller
    {
        public JsonResult Index()
        {
            
            return Json(new {id = 1, name = "Erkan"});
        }
    }
}
