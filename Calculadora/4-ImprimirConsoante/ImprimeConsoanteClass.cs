using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ImprimirConsoante
{
    internal class ImprimeConsoanteClass
    {

        public ImprimeConsoanteClass(String palavra)
        {
            foreach (char c in palavra)

                if (c != 'a' & c != 'e' & c != 'i' & c != 'o' & c != 'u')
                    Console.Write("{0} ", c);
        }
    }
}
