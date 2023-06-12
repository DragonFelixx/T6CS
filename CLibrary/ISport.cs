using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibrary
{
    internal interface ISport
    {
        string SportName { get; set; }

        string GetWinner();
    }
}
