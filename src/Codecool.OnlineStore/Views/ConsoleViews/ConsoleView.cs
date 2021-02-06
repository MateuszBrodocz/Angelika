using System;
using Codecool.OnlineStore.Views.Interfaces;
using Spectre.Console;

namespace Codecool.OnlineStore.Views.ConsoleViews
{
    public class ConsoleView : IView
    {
        public string GetOption(string title, string[] options)
        {
            Console.Clear();
            var choice = AnsiConsole.Prompt(
                         new SelectionPrompt<string>()
                             .Title(title)
                             .PageSize(10)
                             .AddChoices(options));
            return choice;
        }

        public bool GetYesOrNo()
        {
            return ValidateInput.IsYes(Console.ReadKey());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
