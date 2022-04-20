using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Classwork_durak
{
    class Program
    {
        static void Main(string[] args)
        {

            //Koloda koloda = new Koloda();      
            //koloda.Shake();
            //koloda.Show();

            Player player1 = new Player("Oleg");
            Console.WriteLine("Player1 : " + player1.Name);
            Player player2 = new Player("Nadya");

            Play_Table table = new Play_Table(player1, player2);
            table.Shake();
           // Console.WriteLine(table.karty.size());

            table.Razdacha_kart();
            // player1.Show();

            //  Console.WriteLine("Player2 : " + player2.Name);
            //  player2.Show();

           
           

            List<Karta> otboy = new List<Karta>();

            int f = 1;
                while (f == 1)
            {
                
                Karta pl1 = table.igroki[0].Give();
                Karta pl2 = new Karta();
                Console.WriteLine(" 1 - Ход\n 0 - Забрать");

                int ch = int.Parse(System.Console.ReadLine());
                f = ch;
                if (f == 1)
                {
                    pl2 = table.igroki[1].Give();
                    otboy.Add(pl1);
                    otboy.Add(pl2);
                    if (table.Hod(pl1, pl2, 0, 1) == false)
                    {
                       
                        Console.WriteLine( " Забираете?\n 1 - Да 0 - Нет ");
                        int v = int.Parse(System.Console.ReadLine());
                        if (v==1)
                        {
                           
                            table.igroki[1].my_karts.AddRange(otboy);
                            f = 0;
                            Console.WriteLine("Игрок:" + table.igroki[1].Name + " Забрал карты! ");
                            break;
                        }
                        else
                        {
                            table.igroki[1].Take(pl2);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine( " Бито! ");
                    }
                }
                else
                {
                    table.igroki[1].my_karts.AddRange(otboy);
                    table.igroki[1].Take(pl1);
                    Console.WriteLine("Игрок:" + table.igroki[1].Name+" Забрал карты! ");
                    f = 0;
                   
                    break;
                }

             
                f = 1;
            }
            Console.WriteLine(" Igrok 1 -------------");
            table.igroki[0].Show();

            Console.WriteLine(" Igrok 2 -------------");
            table.igroki[1].Show();

            Console.WriteLine("\n\n  Раздача карт  ");
           int k= table.igroki[0].Sum();
            table.Vzat_karty(0, k);

            k = 0;
            k = table.igroki[1].Sum();
          
            table.Vzat_karty(1, k);


            Console.WriteLine(" Igrok 1 -------------");
            table.igroki[0].Show();

            Console.WriteLine(" Igrok 2 -------------");
            table.igroki[1].Show();

        }
    }
}
