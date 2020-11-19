using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;

namespace TwilioSMSTest.Controllers
{
    public class SMSController : TwilioController
    {
        //TODO: Build functionality to send a text to the Twilio number to receive
        //a compliment back
        //TODO: Customize the Index and _Layout

        string[] compliments = 
        {
            "You're doing great!",
            "You're the best!",
            "Keep up the good work!",
            "Nobody does it better than you!",
            "TIGER BLOOD!",
            "You're a champion!",
            "I believe in you!",
            "You can do it!"
        };

        // GET: SMS
        public ActionResult SendText()
        {

            TwilioClient.Init(
                "Account SID goes here",
                "Auth goes here");

            PhoneNumber to = new PhoneNumber("To number goes here");
            PhoneNumber from = new PhoneNumber("From number goes here");
            string body = compliments[new Random().Next(compliments.Length)];

            MessageResource message = MessageResource.Create(
                to: to,
                from: from,
                body: body
                );

            return Content($"Your message (\"{body}\") has been sent successfully!");
        }

    }
}