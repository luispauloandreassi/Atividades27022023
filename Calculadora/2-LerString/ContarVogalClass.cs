using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LerString
{
    internal class ContarVogalClass
    {

        public double ContaVogal(String palavra)
        {
            return palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));

        }
    }
}
