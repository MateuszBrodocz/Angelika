using System;
using System.Text.RegularExpressions;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.Interfaces;
using Spectre.Console;

namespace Codecool.OnlineStore.Views.ConsoleViews
{
    public class GuestView : ConsoleView, IGuestView
    {
        public string GetText(string inputRequestMessage)
        {
            Console.WriteLine(inputRequestMessage);
            string returnString = Console.ReadLine();

            return returnString;
        }

        public bool IsStringValid(string inputString, string regexPattern)
        {
            return Regex.IsMatch(inputString, regexPattern);
        }
    }
}
