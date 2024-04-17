using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Avant
{
    // ReaderAvant.cs:
    // ReaderAvant class represents a reader. It's a concrete implementation that LibraryAvant class depends on.
    internal class ReaderAvant
    {
        public void ReadBook(string book)
        {
            Console.WriteLine("Reading " + book);
        }
    }
}
    // By violating DIP:
    // - LibraryAvant class directly depends on the concrete ReaderAvant class, making it difficult to change or extend the behavior of readers without modifying the LibraryAvant class.
    // - It's challenging to substitute different types of readers without modifying the LibraryAvant class, violating the Open/Closed Principle.
