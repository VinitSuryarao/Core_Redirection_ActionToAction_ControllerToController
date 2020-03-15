using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Redirection_ActionToAction_ControllerToController.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Call Action in Same Controller
        [HttpPost]
        public IActionResult CallActionInSameController()
        {
            return base.RedirectToAction("Index");
        }

        // Call Action  in Different Controller
        [HttpPost]
        public IActionResult CallActionInDiffController()
        {
            // Parameter :- Action Name, Controller Name
            return base.RedirectToAction("Index", "Exchange");
        }

        // Call Different Domain Page
        [HttpPost]
        public IActionResult OnCallDiffDomainPage()
        {
            return base.Redirect("https://www.google.com/");
        }
    }
}