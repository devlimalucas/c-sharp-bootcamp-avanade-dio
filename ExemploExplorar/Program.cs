using ExemploExplorar.Models;
using System.Globalization;

int numero = 15;
bool ehPar = numero % 2 == 0;

Console.WriteLine($"O número é " + (ehPar ? "par" : "ímpar"));
