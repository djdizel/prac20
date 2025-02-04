using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20
{
    public class PersonalComputer
    {
        public string Model { get; set; }
        public double CpuFrequency { get; set; }
        public int RamSize { get; set; }
        public int HddSize { get; set; }

        public PersonalComputer()
        {
            Model = "Неизвестно";
            CpuFrequency = 0;
            RamSize = 0;
            HddSize = 0;
        }

        public PersonalComputer(string model)
        {
            Model = model;
            CpuFrequency = 0;
            RamSize = 0;
            HddSize = 0;
        }

        public PersonalComputer(string model, double cpuFrequency)
        {
            Model = model;
            CpuFrequency = cpuFrequency;
            RamSize = 0;
            HddSize = 0;
        }

        public PersonalComputer(string model, double cpuFrequency, int ramSize)
        {
            Model = model;
            CpuFrequency = cpuFrequency;
            RamSize = ramSize;
            HddSize = 0;
        }

        public PersonalComputer(string model, double cpuFrequency, int ramSize, int hddSize)
        {
            Model = model;
            CpuFrequency = cpuFrequency;
            RamSize = ramSize;
            HddSize = hddSize;
        }

        public void Info()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Тактовая частота процессора: {CpuFrequency} ГГц");
            Console.WriteLine($"Объем оперативной памяти: {RamSize} ГБ");
            Console.WriteLine($"Объем жесткого диска: {HddSize} ГБ");
        }

        public override string ToString()
        {
            return $"Модель: {Model}, Частота: {CpuFrequency} ГГц, ОЗУ: {RamSize} ГБ, Жесткий диск: {HddSize} ГБ";
        }
    }
}
