using System;
using Codecool.OnlineStore.DAL.Interfaces;
using Codecool.OnlineStore.Views.Interfaces;

namespace Codecool.OnlineStore.Views.ConsoleViews
{
    public class CatalogConsoleView : ConsoleView, ICatalogView
    {
        public bool IsCategoryAvailable()
        {
            {
                bool correctInput = true;
                bool isAvailable = false;
                char sign;
                string input;
                Console.WriteLine("Is Category available? Enter y/n");
                do
                {
                    IsWrongInput(correctInput);

                    try
                    {
                        input = Console.ReadLine().ToLower();
                        sign = char.Parse(input);
                        correctInput = ValidateInput.CheckSign(sign, correctInput);
                        isAvailable = ValidateInput.IsAvailableOrNot(sign, isAvailable);
                    }
                    catch (Exception)
                    {
                        correctInput = false;
                    }
                }
                while (!correctInput);
                return isAvailable;
            }
        }

        public string GetCategoryName()
        {
            Console.Write("Enter category name: ");
            return Console.ReadLine();
        }

        public int GetCategoryId(IRepositoryFactory repositoryFactory)
        {
            bool correctInput = true;
            string userInput;
            int id = -1;
            Console.WriteLine("Enter category ID: ");
            do
            {
                IsWrongInput(correctInput);

                try
                {
                    userInput = Console.ReadLine();
                    id = int.Parse(userInput);
                    correctInput = ValidateInput.IsCorrectCategoryId(id, repositoryFactory, correctInput);
                }
                catch (Exception)
                {
                    correctInput = false;
                }
            }
            while (!correctInput);

            return id;
        }

        public void IsWrongInput(bool correctInput)
        {
            if (!correctInput)
            {
                Console.WriteLine("Isn't correct input, try again!");
            }
        }

        public int GetProductId(IRepositoryFactory repositoryFactory)
        {
            bool correctInput = true;
            string userInput;
            int id = -1;
            Console.WriteLine("Enter product ID: ");
            do
            {
                IsWrongInput(correctInput);

                try
                {
                    userInput = Console.ReadLine();
                    id = int.Parse(userInput);
                    correctInput = ValidateInput.IsCorrectProductId(id, repositoryFactory, correctInput);
                }
                catch (Exception)
                {
                    correctInput = false;
                }
            }
            while (!correctInput);

            return id;
        }
    }
}
