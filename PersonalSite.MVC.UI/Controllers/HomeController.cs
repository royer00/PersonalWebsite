using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSite.MVC.UI.Models;
using System.Net.Mail;
using System.Net;


namespace PersonalSite.MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult ContactAjax(ContactViewModel cvm)
        {
            string message = $"{DateTime.Now}-{cvm.Name} has sent you the following message: <br/>" +
                $"{cvm.Message} from the following email address:<strong>{cvm.Email}</strong>";

            MailMessage mail = new MailMessage("","",$"{cvm.Subject}", message);

            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;

            mail.ReplyToList.Add(cvm.Email);

            SmtpClient client = new SmtpClient("");
            client.Credentials = new NetworkCredential("");

            client.Port = 8889;
            try
            {
                client.Send(mail);
            }
            catch (Exception e)
            {

                ViewBag.Message = e.StackTrace;
            }
            return Json(cvm);
        }

        public ActionResult EmailConfirmation(ContactViewModel cvm)
        {
            return View(cvm);
        }
    }
}