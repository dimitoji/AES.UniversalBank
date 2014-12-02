using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace AES.UniversalBank.Portal.Web.Controllers
{
    [Authorize]
    public class AccountInfoController : _AuthorizedControllerBase
    {
        private readonly BusinessLogic.IAccountInfoManager _accountsManager;

        public AccountInfoController(
            BusinessLogic.IAccountInfoManager accountsManager)
        {
            this._accountsManager = accountsManager;
        }

        // GET: Info
        public ActionResult Index()
        {
            var user = this.UserManager.FindById(User.Identity.GetUserId());
            var model = this._accountsManager.GetAccountInfo(user.Email);

            if (model == null)
                return HttpNotFound();

            // Si no hay nombre del CRM, pone el nombre de usuario segun autenticacion
            if(string.IsNullOrWhiteSpace(model.Customer.Name))
                model.Customer.Name = user.UserName;

            return View(model);
        }
    }
}