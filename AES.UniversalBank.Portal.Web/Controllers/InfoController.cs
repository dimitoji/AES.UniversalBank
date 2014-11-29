using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AES.UniversalBank.Portal.Web.Controllers
{
    public class InfoController : Controller
    {
        private readonly BusinessLogic.IAccountsManager _accountsManager;

        public InfoController(BusinessLogic.IAccountsManager accountsManager)
        {
            this._accountsManager = accountsManager;
        }

        // GET: Info
        public ActionResult Index()
        {
            var model = this._accountsManager.GetAccountInfo("");

            if (model == null)
                return HttpNotFound();

            return View(model);
        }
    }
}