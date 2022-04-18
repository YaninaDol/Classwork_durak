using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_durak
{
    class Karta
    {
        
        public int Znach { get; set; }
        public Mast Mast;
        public Karta(int znach, Mast mast)
        {
            Znach = znach;
            Mast = mast;
        }

        public override string ToString()
        {
            return ($"{Znach}{Mast.ToString()}\n{Mast.ToString()}{Mast.ToString()}\n{Mast.ToString()}{Znach}");
        }


    }
}
