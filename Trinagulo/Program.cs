using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Trinagulo;

namespace Program.T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.WriteLine("digite as 3 medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("digite as 3 medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Double areaX = x.Area();
            Double areaY = y.Area();

            Console.WriteLine("area de x: " + areaX);
            Console.WriteLine("area de y: " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: " + areaX);
            }
            else
            {
                Console.WriteLine("Maior área: " + areaY);
            }





        }
    }
}
