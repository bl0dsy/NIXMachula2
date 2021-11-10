using System;

namespace NIXMachula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Узнайте стоимость пирожков в гривнах и копейках в зависимости от их количества");
            int gryven, kopeek, quantity, quantity1, quantity2;
            Console.WriteLine("Введите стоимость одного пирожка в гривнах");
            gryven = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость одного пирожка в копейках");
            kopeek = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество пирожков");
            quantity = int.Parse(Console.ReadLine());
            quantity1 = (gryven * quantity);
            quantity2 =  (kopeek * quantity);
            Console.WriteLine($"Стоимость в гривнах = { quantity1}");
            Console.WriteLine($"Стоимость в копейках = { quantity2}");
        }
    }
}
