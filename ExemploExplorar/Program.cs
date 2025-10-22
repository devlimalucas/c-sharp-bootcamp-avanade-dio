using ExemploExplorar.Models;
using System.Globalization;

(int, string, string, decimal) tupla = (1, "Lucas", "Lima", 10.5M);

ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Lucas", "Lima", 10.5M);

var outroExemploTuplaCreate = Tuple.Create(1, "Lucas", "Lima", 10.5M);

Console.WriteLine(tupla.Item1);
Console.WriteLine(tupla.Item2);
Console.WriteLine(tupla.Item3);
Console.WriteLine(tupla.Item4);