using System;


/*C# 05 (27 сентября 2023)
Исходящие аргументы функций. Исключения
Срок: к следующему занятию, понедельнику 2 октября

1. Напишите самодельную функцию TryParse со следующей подписью:

bool TryParse (string input, out int result);

Её результат работы такой:

• Если получилось преобразовать строку в число, она возвращает true, и в result лежит результат
• Если не получилось, она возвращает false, а в result лежит 0

Чтобы её реализовать, вы можете использовать int.Parse и try / catch (но нельзя использовать int.TryParse).

2. Напишите функцию MultiPrint. Она принимает любое число аргументов и печатает их все.
*/
namespace RefOutParamsHW5
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer:");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int result))
            {
                Console.WriteLine("Parse success c:");
                Console.WriteLine($"RESULT: {result}"  );
            }
            else
            {
                Console.WriteLine("Parse failed :c");
                Console.WriteLine($"RESULT: {result}");
            }
            Random random = new Random();
            
            int[] values = {random.Next(), random.Next(), random.Next(), random.Next() };
            
            multiPrint(values);

        }
        bool TryParse(string input, out int result)
        {
            try
            {
                result = Int32.Parse(input);
                return true;
            }

            catch (FormatException)
            {
                result = 0;
                return false;
            }
        }
        static void multiPrint(params int[] values)
        {
            foreach(int value in values)
                Console.WriteLine(value);
        }
    }
}
