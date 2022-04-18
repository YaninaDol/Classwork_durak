using System;

namespace Classwork_durak
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta(10, new Bubn());
            Karta karta2 = new Karta(6, new Pika());
            Karta karta3 = new Karta(8, new Chirva());
            Karta karta4 = new Karta(7, new Krest());
            Koloda koloda = new Koloda();
            koloda.Addcard(karta);
            Console.WriteLine(karta.ToString() +"\n\n"+ karta2.ToString() + "\n\n"+karta3.ToString() + "\n\n"+karta4.ToString());

        }
    }
}
