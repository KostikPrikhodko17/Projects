using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDIES
{
    class Program
    {
        static void Main(string[] argg)
        {
            Console.WriteLine("Типы данных: Целые числа.");
            //Типы данных

            byte a =  byte.MaxValue;
            byte a1 = byte.MinValue;
            Console.WriteLine($"byte:\n{a}\n {a1}\n");

            sbyte b = sbyte.MaxValue;
            sbyte b1 = sbyte.MinValue;
            Console.WriteLine($"sbate:\n{b}\n {b1}\n");

            short c = short.MaxValue;
            short c1 = short.MinValue;
            Console.WriteLine($"short:\n{c}\n {c1}\n");

            ushort d = ushort.MaxValue;
            ushort d1 = ushort.MinValue;
            Console.WriteLine($"ushort:\n{d}\n {d1}\n");

            int e = int.MaxValue;
            int e1 = int.MinValue;
            Console.WriteLine($"int:\n{e}\n {e1}\n");

            uint f = uint.MaxValue;
            uint f1 = uint.MinValue;
            Console.WriteLine($"uint:\n{f}\n {f1}\n");

            long g = long.MaxValue;
            long g1 = long.MinValue;
            Console.WriteLine($"long:\n{g}\n {g1}\n");

            ulong h = ulong.MaxValue;
            ulong h1 = ulong.MinValue;
            Console.WriteLine($"ulong:\n{h}\n {h1}\n");

            Console.ReadKey();

            Console.WriteLine("Тип данных: cимвол, строка");
            // тип данных

            char i = 'q'; // один любой символ
            Console.WriteLine($"char:\n{i}\n");

            string k = "любое слово, предложение, текст";
            Console.WriteLine($"string:\n{k}\n");

            Console.ReadKey();

            Console.WriteLine("Тип данных. Дробные числа, числа с плавающей точкой.");
            // тип данных

            float l = float.MaxValue;
            float l1 = float.MinValue;
            Console.WriteLine($"float:\n {l}\n{l1}\n");

            double m = double.MaxValue;
            double m1 = double.MinValue;
            Console.WriteLine($"double:\n{m}\n{m1}\n");

            decimal n = decimal.MaxValue;
            decimal n1 = decimal.MinValue;
            Console.WriteLine($"decimal:\n {n}\n{n1}\n");

            Console.ReadKey();
            Console.WriteLine("Скорее всего, какие-то типы данных я пропустил...");
        }
    }