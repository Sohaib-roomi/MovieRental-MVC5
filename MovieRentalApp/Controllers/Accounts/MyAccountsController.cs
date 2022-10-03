using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalApp.Controllers.Accounts
{
    public class MyAccountsController : Controller
    {
        // GET: MyAccounts
        public ActionResult Index()
        {
            return View();
        }
    }
}