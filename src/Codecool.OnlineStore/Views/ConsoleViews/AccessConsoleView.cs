using System;
using System.Collections.Generic;
using System.Linq;
using Codecool.OnlineStore.Models;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Views.ConsoleViews
{
    public class AccessConsoleView : ConsoleView, IAccessView
    {
        public string GetPassword()
        {
            Console.Write("Enter password: ");
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            }
            while (key != ConsoleKey.Enter);

            Console.WriteLine();
            return pass;
        }

        public void ShowRegisterPage()
        {
            Console.Clear();
            Console.WriteLine("Hello guest! You can register here.");
            Console.WriteLine();
        }

        public string GetFirstName()
        {
            string input;
            bool isValid = false;
            do
            {
                Console.Write("Enter your first name: ");
                input = Console.ReadLine();
                if (ValidateInput.OnlyLetherValidSingleWord(3, 50, input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("First name should consist only of letters and have 3-50 characters.");
                }
            }
            while (!isValid);

            return input;
        }

        public string GetLastName()
        {
            string input;
            bool isValid = false;
            do
            {
                Console.Write("Enter your last name: ");
                input = Console.ReadLine();
                if (ValidateInput.OnlyLetherValidSingleWord(3, 50, input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Last name should consist only of letters and have 3-50 characters.");
                }
            }
            while (!isValid);

            return input;
        }

        public string GetPhoneNumber()
        {
            string input;
            bool isValid = false;
            do
            {
                Console.Write("Enter phone number name: ");
                input = Console.ReadLine();
                if (ValidateInput.ValidSingleStringWithNumbersOnly(9, 12, input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Phone number should consist only of 9-12 digits");
                }
            }
            while (!isValid);

            return input;
        }

        public string GetStreetName()
        {
            string input;
            bool isValid = false;
            do
            {
                Console.Write("Enter street name with flat number: ");
                input = Console.ReadLine();
                if (ValidateInput.ValidLength(3, 50, input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You shoul enter 3-50 characters.");
                }
            }
            while (!isValid);

            return input;
        }

        public string GetPostalCode()
        {
            string input;
            bool isValid = false;
            do
            {
                Console.Write("Enter postal code: ");
                input = Console.ReadLine();
                if (ValidateInput.ValidPostalCodeCharacters(5, 10, input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Postal code should consist only of 5-10 characters");
                }
            }
            while (!isValid);

            return input;
        }

        public string GetCityName()
        {
            string input;
            bool isValid = false;
            do
            {
                Console.Write("Enter city name: ");
                input = Console.ReadLine();
                if (ValidateInput.OnlyLetterValidMultipleWord(3, 100, input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("City should consist only of words");
                }
            }
            while (!isValid);

            return input;
        }

        public Country GetCountyFromList(IEnumerable<Country> countries)
        {
            var choosenCountryName = GetOption("Choose your country", countries.Select(c => c.CountryName).ToArray());
            return countries.Where(c => c.CountryName == choosenCountryName).First();
        }

        public string GetUsername()
        {
            Console.Write("Enter username: ");
            return Console.ReadLine();
        }

        public void ShowLoginPage()
        {
            Console.Clear();
            Console.WriteLine("Hello guest! You can login here.");
            Console.WriteLine();
        }
    }
}
