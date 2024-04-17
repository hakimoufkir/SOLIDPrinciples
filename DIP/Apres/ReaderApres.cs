using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Apres
{
    // ReaderApres.cs:
    // ReaderApres class represents a reader, implementing the IReaderApres interface.
    internal class ReaderApres: IReaderApres
    {
        public void ReadBook(string book)
        {
            Console.WriteLine("Reading " + book);
        }
    }
}
