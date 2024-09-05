using System;

namespace RazorZodiac.Models;

/// <summary>
/// Static class Utils represents the only static method which is GetZodiac.
/// </summary>
public class Utils
{

    /// <summary>
    /// Takes in a year and returns the zodiac sign for that year.
    /// </summary>
    /// <param name="year">An integer</param>
    /// <returns></returns>
    public static string GetZodiac(int year) {
        string[] zodiac = new string[12];
        zodiac[0] = "Monkey";
        zodiac[1] = "Rooster";
        zodiac[2] = "Dog";
        zodiac[3] = "Pig";
        zodiac[4] = "Rat";
        zodiac[5] = "Ox";
        zodiac[6] = "Tiger";
        zodiac[7] = "Rabbit";
        zodiac[8] = "Dragon";
        zodiac[9] = "Snake";
        zodiac[10] = "Horse";
        zodiac[11] = "Goat";

        int remainder = year % 12;
        return zodiac[remainder];
    }

}
