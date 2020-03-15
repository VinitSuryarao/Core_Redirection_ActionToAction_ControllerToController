using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Redirection_ActionToAction_ControllerToController.Controllers
{
    public class ExchangeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}