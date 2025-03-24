using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayıyı giriniz: ");
            float sayı1 = float.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz");
            float sayı2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Girilen birinci sayı: ");
            Console.WriteLine(sayı1);
            Console.WriteLine("Girilen ikinci sayı: ");
            Console.WriteLine(sayı2);

            float MaxDeger = float.MaxValue;
            float MinDeger = float.MinValue;
            Console.WriteLine("Max Değer: " + MaxDeger);
            Console.WriteLine("Min Değer: " + MinDeger);

            Console.ReadLine();
            


        }
    }
}
