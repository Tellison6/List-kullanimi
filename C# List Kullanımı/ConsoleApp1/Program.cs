using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int secim;
            List<string> kahveler = new List<string>();
            kahveler.Add("1-) Espresso"); 
            kahveler.Add("2-) Türk Kahvesi"); 
            kahveler.Add("3-) Americano"); 
            kahveler.Add("4-) Latte"); 
            Console.WriteLine("Hoşgeldiniz! Hangi Kahveyi İstersiniz?");
            Console.WriteLine(" ");
            Thread.Sleep(1000);
            foreach (string kahve in kahveler)
            {
                Console.WriteLine(kahve);
            }


            secim = int.Parse(Console.ReadLine());
            
            if (secim == 1)
            {   
                Console.WriteLine("Espresso'nuz hazırlanıyor. Afiyet olsun!");
            }
            else if (secim == 2)
            {
                Console.WriteLine("Türk Kahve'niz hazırlanıyor. Afiyet olsun!");
            }
            else if (secim == 3) 
            {
                Console.WriteLine("Americano'nuz hazırlanıyor. Afiyet olsun!");
            }
            else if (secim == 4)
            {
                Console.WriteLine("Latte'niz hazırlanıyor. Afiyet olsun!");
            }

            Console.ReadLine();
        }
    }
}
