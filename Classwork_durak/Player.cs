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

       public void Take(Karta karta)
        {
            my_karts.Add(karta);
        }
        public Karta this[int ind]
        {
            get { return my_karts[ind]; }
           // set { }
        }
        public void Give()
        {
          for(int i=0;i<my_karts.Count;i++)
            {
                Console.WriteLine("Выберите карту хода:"+(i+1)+my_karts[i]);
            }
            int ch = int.Parse(System.Console.ReadLine());
            my_karts.Remove(my_karts[ch-1]);
        }

    }
}
