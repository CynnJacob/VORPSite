using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VORPSite.Controllers
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
        
        public ActionResult Game(string playerCommand)
        {
            //Game's starting text
            string prologue1 = "<p>You see nothing.  Only darkness, stretching far into the infinite void.  You wonder what happened.  " +
                "Are you dead?  Maybe Mom was right.  Playing with matches in a firework factory might not have been the smartest move.  " +
                "Suddenly, a booming voice cuts through the gloom, strong and bossy.</p>" +
                "<p>\"Why is she still asleep?  I told you to have her ready by four.\"</p>" +
                "<p>A new voice.  This one sounds higher.  A bit panicky, maybe slightly pained.</p>" +
                "<p>\"I don't know!  According to the readouts, she should be awake.  It doesn't make sense.\"</p>" +
                "<p>The bossy voice again.</p>" +
                "<p>\"Well, do something about it.  Can't you, I don't know, inject her or something?\"</p>" +
                "<p>\"I... I can try, ma'am.  It might be dangerous.  Certainly won't be comfortable.\"</p>" +
                "<p>\"I don't care.  It's time.  Do it.\"</p>" +
                "<p>It occurs to you that you might indeed be asleep.  What you are hearing seems strange enough, anyway.</p>";

            //Say "wake up" to get here
            string prologue2 = "<p>Nobody likes getting injections, especially when they aren't needed.  " +
                "Your eyes flit open, filling your vision with harsh flourescent light.  " +
                "It looks like you're in some sort of laboratory.  Complicated-looking equipment lines the walls.  " +
                "A wiry, elderly woman watches with a displeased expression as a young man in a white lab coat nervously holds a needle mere centimeters from your face.</p>";
            
            //Say "speak" to get here
            string prologue3 = "<p>You open your mouth, hoping to stave off a painful poke.  What leaves your mouth is little more than a hoarse whisper.</p>" + 
                "<p>\"ooooooo...\"</p>" +
                "<p>It wasn't quite what you meant to say.  That would have been something more along the lines of \"NOOOOOOOOOO DON\'T PLEASE!\"  " +
                "Still, it seems to work.  The needle retreats.</p>" +
                "\"Ma'am?  She's awake.\"";

            List<string> timePeriods = new List<string>();
            timePeriods.Add("Now");
            timePeriods.Add("November 1989");
            timePeriods.Add("August 1963");
            timePeriods.Add("June 28, 1914");

            List<string> Locations = new List<string>();
            Locations.Add("TimeLab");
            Locations.Add("Berlin");
            Locations.Add("Washington DC");
            Locations.Add("Sarajevo");


            List<string> histEvents = new List<string>();
            histEvents.Add("VORP");
            histEvents.Add("Cold War");
            histEvents.Add("I Have A Dream");
            histEvents.Add("Assassination of Archduke Franz Ferdinand");

            List<string> Scenes = new List<string>();
            Scenes.Add(prologue1);
            Scenes.Add(prologue2);
            Scenes.Add(prologue3);

            ViewBag.Message = "Let's play Vorp!";

            if (playerCommand == "wake up")
            {
                ViewBag.Scene = prologue2;
                return View();
            }
 
            if (playerCommand == "speak")
            {
                ViewBag.Scene = prologue3;
                return View();
            }

            ViewBag.Scene = prologue1;
            return View();
        }
    }
}