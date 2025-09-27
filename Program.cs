using System.Drawing;
using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("Digite o 1° numero");
string um = Console.ReadLine()!;
double one = Convert.ToDouble(um);
Console.WriteLine("Digite o 2° numero");
string dois = Console.ReadLine()!;
double two = Convert.ToDouble(dois);
Console.WriteLine("Digite o 3° numero");
string tres = Console.ReadLine()!;
double three = Convert.ToDouble(tres);
double soma = one + two + three;
double media = 3;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($" Média= {soma / media:N2}");
Console.ResetColor();



