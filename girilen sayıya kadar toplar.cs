using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödeev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
               
                Console.Write("Bir sayı girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int toplam = 0;

               
                for (int i = 1; i <= sayi; i++)
                {
                    toplam += i;  
                }

                
                Console.WriteLine("Girilen sayıya kadar olan sayıların toplamı: " + toplam);
            }
                Console.ReadLine();
        }









    }
}

