using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeFinalGectimiKaldimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //vize final yoluyla ortalama bulunacak:
            //final 50nin altındaysa kalır ayrıca final 50nin üstündeyse ve ortalama 50nin altındaysa yine kalır ☺

            double vize, final, ortalama;
            Console.Write("Vize Notu:");
            vize = double.Parse(Console.ReadLine());
            Console.Write("Final Notu:");
            final = Convert.ToDouble(Console.ReadLine());

            if (final <50)
            {
                Console.WriteLine("Finalden kaldınız");
                
            }
            else//final 50 ve üzerindeyse
            {
                ortalama = vize * .4 + final * .6;
                if (ortalama>=50)
                {
                    Console.WriteLine("Tebrikler {0} ortalama ile geçtiniz.",ortalama);
                }
                else
                {
                    Console.WriteLine("{0} ortalamayla kaldınız",ortalama);
                    
                }
                
            }
            Console.ReadLine();
        }
        
    }
}
