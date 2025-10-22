using ExemploExplorar.Models;
using System.Globalization;

Pessoa p1 = new("Lucas", "Lima");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
