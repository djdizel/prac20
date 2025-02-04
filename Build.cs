using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20
{
    public class Build
    {
        public string name;
        public double area;
        public int kvo;
        public int floor;

        public Build()
        {
            name = "Неизвестно";
            area = 0;
            kvo = 0;
            floor = 0;
        }

        public Build(string name)
        {
            this.name = name;
            area = 0;
            kvo = 0;
            floor = 0;
        }

        public Build(string name, double area)
        {
            this.name = name;
            this.area = area;
            kvo = 0;
            floor = 0;
        }

        public Build(string name, double area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
            floor = 0;
        }

        public Build(string name, double area, int kvo, int floor)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
            this.floor = floor;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название строения: {name}");
            Console.WriteLine($"Площадь строения: {area} м²");
            Console.WriteLine($"Количество жильцов: {kvo}");
            Console.WriteLine($"Количество этажей: {floor}");
            if (kvo > 0)
            {
                double areaPerPerson = area / kvo;
                Console.WriteLine($"Площадь на одного жильца: {areaPerPerson} м²");
            }
            else
            {
                Console.WriteLine("Площадь на одного жильца: Невозможно вычислить (нет жильцов)");
            }
        }
    }
}
