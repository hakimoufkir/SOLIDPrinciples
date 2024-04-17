using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Apres
{
    // LibraryApres.cs:
    // LibraryApres class represents a library. It depends on the IReaderApres interface instead of concrete ReaderApres class, adhering to DIP.

    internal class LibraryApres
    {
        private readonly IReaderApres _reader;

        public LibraryApres(IReaderApres reader)
        {
            _reader = reader;
        }

        public void LendBook(string book)
        {
            _reader.ReadBook(book);
        }
    }
}
