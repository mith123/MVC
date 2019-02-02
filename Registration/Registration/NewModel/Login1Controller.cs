using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.NewModel;
using Registration.Models;

namespace Registration.NewModel
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public RegContext db = new RegContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Login1 lm)
        {
            var u = db.Regs.Where(x => x.username == lm.username & x.password == lm.password).FirstOrDefault();
            if (u == null)
            {
                ModelState.AddModelError("", "inalid username or password");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }


    }
}

