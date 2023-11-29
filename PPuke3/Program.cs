using PPuke3;
using System.Xml.Linq;

var espen = new Espen("Espen", 30, "gaming", "programmer");
var viktor = new Espen("Viktor", 28, "gaming", "programmer");

PrintInfo();
void PrintInfo()
{
    Console.WriteLine("Hvem vil du lese om? 'Viktor', 'Espen'");
    var input = Console.ReadLine();
    switch (input)
    {
        case "Viktor":
            Console.WriteLine($"Hei, mitt navn er {viktor.Name}. ");
            break;
        case "Espen": Console.WriteLine($"Hei, mitt navn er {espen.Name}");
            break;
        default: Console.WriteLine("Invalid input, please select a person");
            break;
    }
}