using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Classwork_durak
{
    class Program
    {
        static void Main(string[] args)
        {


           
           Console.WriteLine(" Введите имя первого игрока : ");
            string Name1 = System.Console.ReadLine();
            Player player1 = new Player(Name1);

            Console.WriteLine(" Введите имя второго игрока : ");
            string Name2 = System.Console.ReadLine();
            Console.Clear();

          

            Player player2 = new Player(Name2);

            Play play = new Play(player1, player2);
            Console.WriteLine(" Нажмите любую клавишу для Старта ");
            Console.ReadLine();
            Console.Clear();

            play.Shake();
            Console.WriteLine(" Козырь игры : " + play.table.kozyr.M.ToString());

            play.Razdacha_kart();
            Console.WriteLine( " Карты игрока "+ play.table.igroki[0].Name);

            play.Show(0);
            Console.ReadLine();
                Console.Clear();
            Console.WriteLine(" Карты игрока " + play.table.igroki[1].Name);
            play.Show(1);
            Console.ReadLine();
            Console.Clear();
           
            int n1 = 0;
            int n2 = 1;
            bool f = true;
            while (play.table.igroki[n1].my_karts.Count != 0 && play.table.igroki[n2].my_karts.Count != 0)
            {

              
                f = true;
                while (f==true)
                {
                   
                    f=play.Start(n1, n2) ;
                }
               
                int t = n1;
                n1= n2;
                n2 = t;
                play.Full_Kart();
               
            }

            if(play.table.igroki[n1].my_karts.Count  < play.table.igroki[n2].my_karts.Count )
            {
                Console.WriteLine( "Победитель : " + play.table.igroki[n1].Name);
            }
            else if (play.table.igroki[n1].my_karts.Count > play.table.igroki[n2].my_karts.Count)
            {
                Console.WriteLine("Победитель : " + play.table.igroki[n2].Name);
            }
            else
            {
                Console.WriteLine(" Победила дружба! ");
            }

           
            Console.WriteLine(" Игра окончена! ");
        }
    }
}
