using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougeGame
{
    public class BagFullException : ApplicationException
    {
        private static string msg = "Bag is full";
        public BagFullException() :base(msg)
        {
        }
    }
}
