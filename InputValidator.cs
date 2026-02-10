using System;
using System.Collections.Generic;
using System.Globalization;

namespace Registrar
{
    static class InputValidator
    {
        public static double ValidarDouble(string menssagem)
        {
            double num;
            Console.WriteLine(menssagem);
            while (!double.TryParse(Console.ReadLine(),NumberStyles.Any, CultureInfo.InvariantCulture, out num))
            {
                Console.WriteLine("Inválido, Tente novamente!");
            }
            return num;
        }
        public static int ValidarInt(string menssagem)
        {
            int num;
            Console.WriteLine(menssagem);
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Inválido, Tente novamente!");
            }
            return num;
        }
    }   
}
