using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using TheJWal.Models;

namespace TheJWal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Portfolio()
        {

            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(EmailModel ContactForm)
        {
            string messageBody =
                string.Format(
                    "<strong>From:</strong> {0}<br /><strong>Subject:</strong> {1}<br /><strong>Sender Email:</strong> {2}<br /><strong>Message:</strong> {3}",
                    ContactForm.Name, ContactForm.Subject, ContactForm.SenderEmail, ContactForm.Message);

            MailMessage email = new MailMessage("jwaldron@thejwal.com", "jwaldron@thejwal.com", "Mail from TheJWal.com", messageBody);
            email.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("mail.thejwal.com");
            smtp.UseDefaultCredentials = false;



            email.Priority = MailPriority.High;

            smtp.Send(email);
            return View("Index");
        }
    }
}
