using System;
using System.Linq;
using System.Text.RegularExpressions;
using Codecool.OnlineStore.DAL.Interfaces;

namespace Codecool.OnlineStore.Views
{
    public static class ValidateInput
    {
        public static bool IsYes(ConsoleKeyInfo consoleKeyInfo)
        {
            return consoleKeyInfo.Key == ConsoleKey.Y;
        }

        /// <summary>
        /// Numbers in corect Value Range
        /// </summary>
        /// <param name="minValue">Mmin value of input</param>
        /// <param name="maxAValue">Max value of input</param>
        /// <param name="input">User input for valid</param>
        /// <returns>True or false</returns>
        public static bool OnlyNumberValid(int minValue, int maxAValue, string input)
        {
            bool isCorrectInput = false;
            int inputNumberIntformat;
            bool isInputLetherCorrect = int.TryParse(input, out inputNumberIntformat);
            if (isInputLetherCorrect)
            {
                if ((inputNumberIntformat >= minValue) && (inputNumberIntformat <= maxAValue))
                {
                    isCorrectInput = true;
                }
            }

            return isCorrectInput;
        }

        /// <summary>
        /// Lethers with corect Lenght
        /// </summary>
        /// <param name="minLenght">Minimal Lenght of String</param>
        /// <param name="maxLenght">Maximal Lenght of String</param>
        /// <param name="input">User Input </param>
        /// <returns>True if valid, false if not</returns>
        public static bool OnlyLetherValidSingleWord(int minLenght, int maxLenght, string input)
        {
            bool isCorrectInput = false;
            if ((input.Length <= maxLenght) && (input.Length >= minLenght) && Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                isCorrectInput = true;
            }

            return isCorrectInput;
        }

        public static bool ValidSingleStringWithLettersAndNumbers(int minLenght, int maxLenght, string input)
        {
            bool isCorrectInput = false;
            if ((input.Length <= maxLenght) && (input.Length >= minLenght) && Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"))
            {
                isCorrectInput = true;
            }

            return isCorrectInput;
        }

        public static bool ValidSingleStringWithNumbersOnly(int minLenght, int maxLenght, string input)
        {
            bool isCorrectInput = false;
            if ((input.Length <= maxLenght) && (input.Length >= minLenght) && Regex.IsMatch(input, @"^[0-9]+$"))
            {
                isCorrectInput = true;
            }

            return isCorrectInput;
        }

        public static bool ValidLength(int minLenght, int maxLenght, string input)
        {
            bool isCorrectInput = false;
            if ((input.Length <= maxLenght) && (input.Length >= minLenght))
            {
                isCorrectInput = true;
            }

            return isCorrectInput;
        }

        public static bool ValidPostalCodeCharacters(int minLenght, int maxLenght, string input)
        {
            bool isCorrectInput = false;
            if ((input.Length <= maxLenght) && (input.Length >= minLenght) && Regex.IsMatch(input, @"^[A-Za-z0-9]+[-\s][a-zA-Z0-9]+$"))
            {
                isCorrectInput = true;
            }

            return isCorrectInput;
        }

        public static bool OnlyLetterValidMultipleWord(int minLenght, int maxLenght, string input)
        {
            bool isCorrectInput = false;
            if ((input.Length <= maxLenght) && (input.Length >= minLenght))
            {
                if (Regex.IsMatch(input, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
                {
                    isCorrectInput = true;
                }
            }

            return isCorrectInput;
        }

        public static bool CheckSign(char sign, bool correctInput)
        {
            if (sign != 'y' && sign != 'n')
            {
                correctInput = false;
            }
            else if (sign == 'y')
            {
                correctInput = true;
            }
            else if (sign == 'n')
            {
                correctInput = true;
            }

            return correctInput;
        }

        public static bool IsAvailableOrNot(char sign, bool isAvailable)
        {
            if (sign == 'y')
            {
                isAvailable = true;
            }
            else if (sign == 'n')
            {
                isAvailable = false;
            }

            return isAvailable;
        }

        public static bool IsCorrectCategoryId(int id, IRepositoryFactory repositoryFactory, bool correctInput)
        {
            var allCategories = repositoryFactory.Categories.GetAll();
            if (id > allCategories.Count())
            {
                correctInput = false;
            }
            else if (id < 0)
            {
                correctInput = false;
            }
            else
            {
                correctInput = true;
            }

            return correctInput;
        }

        public static bool IsCorrectProductId(int id, IRepositoryFactory repositoryFactory, bool correctInput)
        {
            var allCategories = repositoryFactory.Products.GetAll();
            if (id > allCategories.Count())
            {
                correctInput = false;
            }
            else if (id < 0)
            {
                correctInput = false;
            }
            else
            {
                correctInput = true;
            }

            return correctInput;
        }
    }
}
