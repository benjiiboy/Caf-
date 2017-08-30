using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Café
{
    public abstract class Cafe
    {
        public abstract int Pris();


        public virtual string Styrke()
        {
            return "Stærk";

        }




    }
}
