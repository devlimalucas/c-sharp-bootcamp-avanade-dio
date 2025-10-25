using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using ExemploPOO.Models;

Calculadora c1 = new();

Console.WriteLine(c1.Somar(1, 2));
Console.WriteLine(c1.Subtrair(1, 2));
Console.WriteLine(c1.Multiplicar(1, 2));
Console.WriteLine(c1.Dividir(1, 2));
