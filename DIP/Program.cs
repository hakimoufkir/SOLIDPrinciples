using DIP.Apres;
using DIP.Avant;
using System.Reflection.PortableExecutable;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------Avant----------------------------//

            LibraryAvant libraryavant = new LibraryAvant();
            libraryavant.LendBook("C# Programming");


            //--------------------Apres----------------------------//
            IReaderApres reader = new ReaderApres();
            LibraryApres library = new LibraryApres(reader);
            library.LendBook("C# Programming");
        }
    }
}


// By adhering to DIP:
// - LibraryApres class depends on the abstraction (IReaderApres interface) instead of concrete implementations, making it easier to change or extend the behavior of readers without modifying the LibraryApres class.
// - Different types of readers can be easily substituted without modifying the LibraryApres class, adhering to the Open/Closed Principle.
