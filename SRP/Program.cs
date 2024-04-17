using SRP.Apres;

namespace SRP
{
    internal class Program
    {
        // Main:
        // This is my Program.cs script:
        // Within Main, we instantiate PlayerApresDAOL for file operations and call its SaveToFile method, adhering to SRP by segregating file-saving concerns from other operations.
        static void Main(string[] args)
        {
            PlayerApresDAOL playerApresDAOL = new PlayerApresDAOL();
            Task TaskToSaveFile =  playerApresDAOL.SaveToFile(new PlayerApres(1, "hamid", 23f));
        }
    }
}

        // By adhering to SRP:
        // - Code becomes more modular, making it easier to understand, maintain, and extend.
        // - Each class has a clear and distinct purpose, reducing the risk of unintended side effects when modifying code.
        // - Changes to one aspect of the system, such as file-saving logic, are isolated and do not affect unrelated components.
        // - Promotes code reusability and enhances testability, as each class encapsulates a single, well-defined behavior.