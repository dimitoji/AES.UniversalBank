using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace AES.UniversalBank.Portal.Web.Controllers
{
    [Authorize]
    public class PaymentsController : _AuthorizedControllerBase
    {
        private readonly BusinessLogic.IPaymentsManager _paymentsManager;

        public PaymentsController(
            BusinessLogic.IPaymentsManager paymentsManager)
        {
            this._paymentsManager = paymentsManager;
        }

        // GET: Info
        public ActionResult Index()
        {
            var user = this.UserManager.FindById(User.Identity.GetUserId());
            var model = this._paymentsManager.GetCustomerPayments(user.Email);

            if (model == null)
                return HttpNotFound();
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}