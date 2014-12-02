using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;

namespace AES.UniversalBank.Portal.Web.Controllers
{
    [Authorize]
    public class AccountsController : _AuthorizedControllerBase
    {
        private readonly BusinessLogic.IAccountsManager _accountsManager;

        public AccountsController(
            BusinessLogic.IAccountsManager accountsManager)
        {
            this._accountsManager = accountsManager;
        }

        // GET: Info
        public ActionResult Index()
        {
            var user = this.UserManager.FindById(User.Identity.GetUserId());
            var model = this._accountsManager.GetCustomerAccounts(user.Email);

            if (model == null)
                return HttpNotFound();
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Detail(string id)
        {
            var model = this._accountsManager.GetAccountTransactions(id);

            return View(model);
        }
    }
}