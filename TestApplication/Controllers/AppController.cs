using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Models;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService mailService;

        public AppController(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.title = "Contact Us";

            
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            ViewBag.title = "Contact Us";
            if(ModelState.IsValid)
            {
                mailService.SendMessage("sito814@outlook.com", model.Subject, $"From: {model.Name}, {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            } else
            {

            }

            return View();
        }
        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.title = "About Us";

            return View();
        }
    }
}
