﻿using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour <17 ? "Dzień Dobry " : "Dobry wieczór";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: wyslij zawartosc guestResponse do organizatora przyjeci
                return View("Thanks", guestResponse);
            } else
            {
                // bład kontroli poprawnosci , wiec ponownie wyswietlamy formularz wprowadzania danych
                return View();
            }
        }
    }
}