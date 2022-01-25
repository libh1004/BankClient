using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankClient.Controllers
{
    public class BankController : Controller
    {
        BankService.BankServiceClient bankclient = new BankService.BankServiceClient();
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult GetInformation()
        {
            return View();
        }
        public ActionResult WithDraw()
        {
            return View();
        }
        public ActionResult Deposit()
        {
            return View();
        }
        public ActionResult TransactionHistory()
        {
            return View();
        }
    }
}