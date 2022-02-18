using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var converter = new Converter(28.49, 32.49, 0.38);

            Console.WriteLine("Виберiть що потрiбно робити:");
            Console.WriteLine("1: конвертувати у гривню");
            Console.WriteLine("2: Конвертувати з гривнi");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertTo(converter);
                    break;
                case 2:
                    ConvertFrom(converter);
                    break;
            }

            Console.WriteLine("Зроблено");
            Console.ReadKey();
        }

        private static void ConvertTo(Converter Converter)
        {
            Console.WriteLine("Виберiть що потрiбно робити:");
            Console.WriteLine("1: Конвертувавти з USD");
            Console.WriteLine("2: Конвертувавти з EUR");
            Console.WriteLine("3: Конвертувавти з RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сумму");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(Converter.ConvertFromUsd(input));
                    break;
                case 2:
                    Console.WriteLine(Converter.ConvertFromEur(input));
                    break;
                case 3:
                    Console.WriteLine(Converter.ConvertFromRub(input));
                    break;
            }
        }

        private static void ConvertFrom(Converter Converter)
        {
            Console.WriteLine("Виберiть що потрiбно робити:");
            Console.WriteLine("1: Конвертувавти в USD");
            Console.WriteLine("2: Конвертувавти в EUR");
            Console.WriteLine("3: Конвертувавти в RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сумму");

            var input = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(Converter.ConvertToUsd(input));
                    break;
                case 2:
                    Console.WriteLine(Converter.ConvertToEur(input));
                    break;
                case 3:
                    Console.WriteLine(Converter.ConvertToRub(input));
                    break;
            }
        }
    }
}