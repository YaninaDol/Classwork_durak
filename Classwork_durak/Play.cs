using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Classwork_durak
{
    class Play
    {
        public List<Karta> otboy;
        public Play_Table table;

        public Play(Player player1, Player player2)
        {
            otboy = new List<Karta>();
            table = new Play_Table(player1, player2);
        }

        public void Shake()
        {
            table.Shake();
        }

        public void Razdacha_kart()
        {
            table.Razdacha_kart();
        }

        public bool Start(int player1, int player2)
        {
            int f = 1;
            while (f == 1)
            {
                Console.Clear();
           
                Console.WriteLine(" Козырь игры : " + table.kozyr.M.ToString());

                Karta pl1 = table.igroki[player1].Give();
                Console.Clear();
                Console.WriteLine(" Козырь игры : " + table.kozyr.M.ToString());
                Console.WriteLine(pl1.ToString()+ "\n\n");

                Karta pl2 = new Karta();

                Console.WriteLine(" Карты игрока " + table.igroki[player2].Name);
                table.igroki[player2].Show();
                Console.WriteLine(" 1 - Ход\n 0 - Забрать");

            

                int ch = int.Parse(System.Console.ReadLine());
                f = ch;
                Console.Clear();
                Console.WriteLine(" Козырь игры : " + table.kozyr.M.ToString());
                Console.WriteLine(pl1.ToString() + "\n\n");
                if (f == 1)
                {
                    Console.Clear();
                    Console.WriteLine(" Козырь игры : " + table.kozyr.M.ToString());
                    Console.WriteLine(pl1.ToString() + "\n\n");


                    pl2 = table.igroki[player2].Give();
                    Console.Clear();
                 

                    Console.WriteLine(pl1.ToString() + "\n\n");
                    Console.WriteLine(pl2.ToString() + "\n\n");
                  
                    otboy.Add(pl1);
                    otboy.Add(pl2);
                    if (table.Hod(pl1, pl2, player1, player2) == false)
                    {

                        Console.WriteLine(" Забираете?\n 1 - Да 0 - Нет ");
                        int v = int.Parse(System.Console.ReadLine());
                        if (v == 1)
                        {
                            Console.Clear();
                            table.igroki[player2].my_karts.AddRange(otboy);
                            otboy.Clear();
                            f = 0;
                            Console.WriteLine("Игрок:" + table.igroki[player2].Name + " Забрал карты! ");

                            Thread.Sleep(3000);
                            Console.Clear();
                          
                            return false;
                        }
                        else
                        {
                            table.igroki[player2].Take(pl2);
                            break;
                        }
                    }
                    else
                    {

                        Console.WriteLine(" Бито! ");
                        Thread.Sleep(3000);
                        Console.Clear();

                        Console.WriteLine(" Козырь игры : " + table.kozyr.M.ToString()+ "\n\n\n");
                        Console.WriteLine(" Карты игрока " + table.igroki[player1].Name);
                        table.igroki[player1].Show();
                        Console.WriteLine(" 1 - Отбой ");
                        Console.WriteLine(" 2 - Подкинуть карту ");

                        int bito = int.Parse(System.Console.ReadLine());
                        if (bito == 1)
                        {
                            Console.Clear();
                            otboy.Clear();
                            return false;
                        }
                        else { f = 1; }

                    }
                }
                else
                {
                   
                    table.igroki[player2].my_karts.AddRange(otboy);
                    otboy.Clear();
                    table.igroki[player2].Take(pl1);
                    Console.WriteLine("Игрок:" + table.igroki[player2].Name + " Забрал карты! ");

                    f = 0;
                    Thread.Sleep(3000);
                    Console.Clear();
                    return false;
                }


                f = 1;
            }
            return false;
        }

        public void Show(int player)
        {

            table.igroki[player].Show();
        }

        public void Full_Kart()
        {
            int k = table.igroki[0].Sum();
            table.Vzat_karty(0, k);

            k = 0;
            k = table.igroki[1].Sum();

            table.Vzat_karty(1, k);
        }

    }
}
