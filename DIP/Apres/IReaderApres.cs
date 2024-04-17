using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Apres
{
    // IReaderApres.cs:
    // IReaderApres interface defines common behavior for readers.
    internal interface IReaderApres
    {
        void ReadBook(string book);
    }
}
