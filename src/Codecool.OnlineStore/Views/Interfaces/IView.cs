namespace Codecool.OnlineStore.Views.Interfaces
{
    public interface IView
    {
        void ShowMessage(string message);

        bool GetYesOrNo();

        string GetOption(string title, string[] options);
    }
}
