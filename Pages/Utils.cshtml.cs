using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorZodiac.Models;

namespace RazorZodiac.Pages
{
    /// <summary>
    /// UtilsModel class represents the code-behind for the Utils page.
    /// 
    /// Name: Teddy Dumam-Ag
    /// Date: 2024-09-04
    /// Student ID: A01329707
    /// </summary>
    public class UtilsModel : PageModel
    {

        /// <summary>
        /// Year property represents the year input from the user in the form.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Images property represents the images name for each zodiac sign.
        /// </summary>
        private string[] images { 
            get
            {
                return new string[]
                {
                    "monkey.png",
                    "rooster.png",
                    "dog.png",
                    "pig.png",
                    "rat.png",
                    "ox.png",
                    "tiger.png",
                    "rabbit.png",
                    "dragon.png",
                    "snake.png",
                    "horse.png",
                    "goat.png"
                };
            }
        }

        /// <summary>
        /// OnGet method is called when the page is loaded.
        /// </summary>
        public void OnGet()
        {
            ViewData["Zodiac"] = ""; 
        }


        /// <summary>
        /// OnPost method is called when the form is submitted.
        /// It takes in the year input from the user and returns the zodiac sign for that year.
        /// It also sets a success and failed attempt message to the user.
        /// </summary>
        /// <param name="year">An integer (from the number input)</param>
        /// P.S, Credit GitHub Co-Pilot for the two methods.
        /// Interesting discovery
        // This method may contain the year parameter and have the input contain a name, "year"
        // But the other way of doing this is just binding the Year property so its property can be just used for the GetZodiac function
        public void OnPost(int year)
        {
            if (year < 1900 || year > 2025)
            {
                ViewData["Color"] = "danger";
                ViewData["Message"] = "Year must be between 1900 and next year. Please try again.";
                return;
            }
            ViewData["Zodiac"] = Utils.GetZodiac(year); // get the zodiac sign
            ViewData["Message"] = "Your zodiac is "; // success piece of message
            ViewData["Image"] = images[year % 12]; // get the image name for the zodiac sign
            ViewData["Color"] = "success"; // bootstrap
        }

    }
}
