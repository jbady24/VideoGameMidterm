using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    interface IArmor
    {
        int DefenseValue { get; }
        bool IsNatural { get; }
    }
}
