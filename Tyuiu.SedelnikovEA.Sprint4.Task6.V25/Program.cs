using Tyuiu.SedelnikovaEA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.SedelnikovaEA.Sprint4.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] sports = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };

            Console.WriteLine("Исходный массив элементов:");
            for (int i = 0; i < sports.Length; i++)
            {
                Console.WriteLine($"[{i}]: {sports[i]}");
            }
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(sports);

            Console.WriteLine("Количество элементов, длина которых больше 6: " + res);

            Console.ReadLine();
        }
    }
}
