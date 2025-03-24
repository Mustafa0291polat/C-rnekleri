using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long birinci = 575000;
            long ikinci = -500;
            long MaxDeger = long.MaxValue;
            long MinDeger = long.MinValue;
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);

            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);

            Console.WriteLine("Lütfen bir sayı giriniz");
            long sayı1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Klavyeden girilen sayı : "+sayı1);

            Console.ReadLine();
        }
    }
}
