using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_durak
{
   abstract class Mast
    {

        public char M { get; set; }

        protected Mast(char m)
        {
            M = m;
        }

        public override string ToString()
        {
            return ($" {M}");
        }
    }
}
