using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_durak
{
    class Koloda
    {
        public Stack<Karta> koloda = new Stack<Karta>();
        public Karta[] mas=new Karta[36];
        public Koloda()
        {
           mas[0]= new Karta(6, new Bubn());
           mas[1] = new Karta(6, new Chirva());
           mas[2] = new Karta(6, new Krest());
           mas[3] = new Karta(6, new Pika());

            mas[4] = new Karta(7, new Bubn());
            mas[5] = new Karta(7, new Chirva());
            mas[6] = new Karta(7, new Krest());
            mas[7] = new Karta(7, new Pika());

            mas[8] = new Karta(8, new Bubn());
            mas[9] = new Karta(8, new Chirva());
            mas[10] = new Karta(8, new Krest());
            mas[11] = new Karta(8, new Pika());

            mas[12] = new Karta(9, new Bubn());
            mas[13] = new Karta(9, new Chirva());
            mas[14] = new Karta(9, new Krest());
            mas[15] = new Karta(9, new Pika());

            mas[16] = new Karta(10, new Bubn());
            mas[17] = new Karta(10, new Chirva());
            mas[18] = new Karta(10, new Krest());
            mas[19] = new Karta(10, new Pika());

            mas[20] = new Karta(11, new Bubn());
            mas[21] = new Karta(11, new Chirva());
            mas[22] = new Karta(11, new Krest());
            mas[23] = new Karta(11, new Pika());

            mas[24] = new Karta(12, new Bubn());
            mas[25] = new Karta(12, new Chirva());
            mas[26] = new Karta(12, new Krest());
            mas[27] = new Karta(12, new Pika());

            mas[28] = new Karta(13, new Bubn());
            mas[29] = new Karta(13, new Chirva());
            mas[30] = new Karta(13, new Krest());
            mas[31] = new Karta(13, new Pika());

            mas[32] = new Karta(14, new Bubn());
            mas[33] = new Karta(14, new Chirva());
            mas[34] = new Karta(14, new Krest());
            mas[35] = new Karta(14, new Pika());
           
        }

        public void Addcard(Karta karta)
        {
            koloda.Push(karta);
        }
        public void Sbros(Karta karta)
        {
            koloda.Clear();
            this.koloda = new Stack<Karta>(mas);
        }
        public void Shake()
        {
            Random random = new Random();
            for(int i=0;i<36;i++)
            {
                int ch = random.Next(0, 36);
                if(!koloda.Contains(mas[ch]))
                {
                    this.Addcard(mas[ch]); 
                }
            }

        }
        public void Remove() => koloda.Pop();
        public void Show()
        {
            foreach(Karta i in koloda)
            {
                Console.WriteLine(i.ToString()+"\n");
            }
        }
    }
}
