using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20
{    internal class Program
    {
        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.name = "Дом 1";
            dom1.area = 150.5;
            dom1.kvo = 4;
            dom1.floor = 2;

            Console.WriteLine("Информация о dom1:");
            dom1.ShowInfo();
            Console.WriteLine();

            Build dom2 = new Build("Дом 2", 200.0, 5, 3);

            Console.WriteLine("Информация о dom2:");
            dom2.ShowInfo();
            Console.WriteLine();

            Console.WriteLine("Введите параметры для dom3:");
            Console.Write("Название строения: ");
            string name = Console.ReadLine();
            Console.Write("Площадь строения: ");
            double area = double.Parse(Console.ReadLine());
            Console.Write("Количество жильцов: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int floor = int.Parse(Console.ReadLine());

            Build dom3 = new Build(name, area, kvo, floor);

            Console.WriteLine("Информация о dom3:");
            dom3.ShowInfo();

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
