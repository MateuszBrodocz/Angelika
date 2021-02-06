using System;
using System.Collections.Generic;
using System.Text;

namespace Codecool.OnlineStore.Views.ConsoleViews
{
    public class UserInputSequenceView
    {
        public string InputUser()
        {
            string input = Console.ReadLine();
            return input;
        }

        public string SingleWordSeter(int minLenghtString, int maxLenghtString)
        {
            string input = null;
            bool isCorrectInput = false;
            while (isCorrectInput == false)
            {
                LetherNumberMessage(minLenghtString, maxLenghtString);
                input = InputUser();
                isCorrectInput = ValidateInput.OnlyLetterValidMultipleWord(minLenghtString, maxLenghtString, input);
                if (isCorrectInput == true)
                {
                    CorrectInputMessage();
                    break;
                }
                else
                {
                    WrongInputMessage();
                }
            }

            return input;
        }

        public string MultipleWordSeter(int minLenghtString, int maxLenghtString)
        {
            string input = null;
            bool isCorrectInput = false;
            while (isCorrectInput == false)
            {
                LetherNumberMessage(minLenghtString, maxLenghtString);
                input = InputUser();
                isCorrectInput = ValidateInput.OnlyLetterValidMultipleWord(minLenghtString, maxLenghtString, input);
                if (isCorrectInput == true)
                {
                    CorrectInputMessage();
                    break;
                }
                else
                {
                    WrongInputMessage();
                }
            }

            return input;
        }

        public int NumberSeter(int minValue, int maxValue)
        {
            string input = null;
            bool isCorrectInput = false;
            while (isCorrectInput == false)
            {
                NumberValueMessage(minValue, maxValue);
                input = InputUser();
                isCorrectInput = ValidateInput.OnlyNumberValid(minValue, maxValue, input);

                if (isCorrectInput == true)
                {
                    CorrectInputMessage();
                }
                else
                {
                    WrongInputMessage();
                }
            }

            return Convert.ToInt32(input);
        }

        public void WrongInputMessage()
        {
            Console.WriteLine("Wrong input");
        }

        public void CorrectInputMessage()
        {
            Console.WriteLine("Correct input");
        }

        /// <summary>
        /// Console Message with parameters Min And Max Number Of characters
        /// </summary>
        /// <param name="min">Min Lenght</param>
        /// <param name="max">Max Lenght</param>
        public void LetherNumberMessage(int min, int max)
        {
            Console.WriteLine($"Min {min} Max {max} Lenght");
        }

        /// <summary>
        /// Console Message with parameters Min And Max Value Of Number
        /// </summary>
        /// <param name="min">Min Lenght</param>
        /// <param name="max">Max Lenght</param>
        public void NumberValueMessage(int min, int max)
        {
            Console.WriteLine($"Min {min} Max {max} Value");
        }
    }
}
