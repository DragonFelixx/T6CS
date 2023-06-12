using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    internal interface ILightSource
    {
        string SourceType { get; set; }

        bool IsActive();
    }
}
