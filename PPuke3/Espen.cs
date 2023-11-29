using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPuke3
{
    internal class Espen
    {
        public string Name;
        public int Age;
        public string Hobby;
        public string Profession;

        public Espen(string name, int age, string hobby, string profession)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
            Profession = profession;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Hvem vil du lese om? 'Viktor', 'Espen'");
            var input = Console.ReadLine();
            switch (input)
            {
                case "Viktor": Console.WriteLine($"Hei, mitt navn er {Name}. ");
                    break;
            }
        }
    }
}
