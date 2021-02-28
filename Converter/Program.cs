using ConverterLibrary;
using System;

namespace Converter
{
    class Program
    {
        static void Main()
        {
            uint valueToConvert;

            Console.Write("Введите неотрицательное целое десятичное число: ");

            while (!UInt32.TryParse(Console.ReadLine(), out valueToConvert))
            {
                Console.Write("Неверный ввод. Попробуйте еще: ");
            }

            Console.WriteLine("Данное число в двоичном формате (получено с использованием библиотечный методов конвертирования): ");
            Console.WriteLine(CustomConverter.ConvertToBinaryString(valueToConvert));

            Console.WriteLine("Данное число в двоичном формате (получено без использования библиотечных методов конвертирования ): ");
            Console.WriteLine(CustomConverter.ConvertToBinaryStringCustom(valueToConvert));
        }
    }
}
