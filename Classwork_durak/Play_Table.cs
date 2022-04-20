using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_durak
{
    class Play_Table
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Koloda karty = new Koloda();

        public Mast kozyr;
        public Player[] igroki = new Player[2];
        public Play_Table()
        {

        }
        public Play_Table(Player player1, Player player2)
        {
            igroki[0] = player1;
            igroki[1] = player2;

        }
        public void Shake()
        {
            karty.Shake();
            kozyr= this.Kozyr();
            Console.WriteLine( " Козырь игры : " + kozyr.M.ToString() ); 
        }
        public Player this[int ind]
        {
            get { return igroki[ind]; }
            // set { }
        }
        public void Razdacha_kart()
        {
           
            for (int i = 0; i < 6; i++)
            {
                igroki[0].Take(karty.Remove(), kozyr);
                igroki[1].Take(karty.Remove(), kozyr);
            }
           
        }
        public void Vzat_karty(int id_igrok, int kol)
        {

            for (int i = 0; i < kol; i++)
            {
                igroki[id_igrok].Take(karty.Remove(), kozyr);
               
            }

        }

        public bool Hod(Karta play1, Karta play2,int n1,int n2)
        {
            if (  play2.Mast.M.ToString() == this.kozyr.M.ToString())
            {
                {

                    if (play1.Znach > play2.Znach)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            else if  (play1.Mast.M.ToString() == play2.Mast.M.ToString())
            {
                if (play1.Znach > play2.Znach)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            else
            {
                Console.WriteLine(" Карта не подходит! ");
                return false;
            }
           

        }

        public Mast Kozyr()
        {
            Mast[] kosyr = new Mast[4];

            kosyr[0] = new Chirva();
            kosyr[1] = new Krest();
            kosyr[2] = new Bubn();
            kosyr[3] = new Pika();

            Random random = new Random();
             int m = random.Next(0, 4);
             return kosyr[m];
            


        }
    }
}
