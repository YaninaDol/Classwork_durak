using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_durak
{
    class Karta
    {
        
        public string Znak { get; set; }
        public int Znach { get; set; }
        public Mast Mast;

        public Karta()
        {

        }
        public Karta(int znach, Mast mast)
        {
            Znach = znach;
            Mast = mast;

            string znak = Convert.ToString(znach);
            if(znach<=10)
            {
                Znak = znak;
            }
            else if(znach==11)
            {
                Znak = "B";
            }
            else if (znach == 12)
            {
                Znak = "Q";
            }
            else if (znach == 13)
            {
                Znak = "K";
            }
            else if (znach == 14)
            {
                Znak = "T";
            }

        }
        public void Kozir(Mast mast)
        {
            if (Mast.M.ToString() == mast.M.ToString())
            {
                this.Znach += 9;
            }
        }
        public override string ToString()
        {
            return ($"{Znak}{Mast.ToString()}\n{Mast.ToString()}{Mast.ToString()}\n{Mast.ToString()}{Znak}");
        }
      
      

       
    }
}
