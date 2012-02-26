using System.Web.Mvc;
using ReceiptLog.Areas.Mobile.Models;

namespace ReceiptLog.Areas.Mobile.Controllers
{
    public class LogController : Controller
    {
        public ActionResult Index()
        {
            return View(new LogCreateViewModel());
        }

        [HttpPost]
        public ActionResult Index(LogCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var rle = new ReceiptLogEntities();

            rle.AddToLogs(new Log
                                                   {
                                                       AccountName = model.AccountName,
                                                       Amount = model.Amount.Value,
                                                       When = model.When,
                                                       Where = model.Where,
                                                       Why = model.Why
                                                   });

            rle.SaveChanges();

            TempData["flash"] = "Logged";

            return RedirectToAction("Index");
        }
    }
}
