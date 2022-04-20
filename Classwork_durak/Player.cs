using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_durak
{
    class Player:Hand
    {
        public string Name { get; set; }

        public List<Karta> my_karts;
       

        public Player(string name)
        {
            Name = name;
            my_karts=new List<Karta>();
        }

       public void Take(Karta karta,Mast mast)
        {
            karta.Kozir(mast);
            my_karts.Add(karta);
        }
        public void Take(Karta karta)
        {
            
            my_karts.Add(karta);
        }
        public Karta this[int ind]
        {
            get { return my_karts[ind]; }
           // set { }
        }
        public Karta Give()
        {
            Console.WriteLine("Выберите карту хода:");

            for (int i=0;i<my_karts.Count;i++)
            {       
                Console.WriteLine( $"{i+1} \n {my_karts[i].ToString()}");
            }

            int ch = int.Parse(System.Console.ReadLine());
            Karta back = my_karts[ch - 1];
            my_karts.Remove(my_karts[ch-1]);
            return back;
        }
        public int Sum()
        {
            int sum = 6;
            sum -= this.my_karts.Count;
            if (sum > 0) return sum;
            else return 0;
        }
        public void Show()
        {
            foreach (Karta i in my_karts)
            {
                Console.WriteLine( i.ToString() + "\n");
            }
        }

    }
}
