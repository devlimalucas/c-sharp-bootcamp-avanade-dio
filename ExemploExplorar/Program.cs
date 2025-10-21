using ExemploExplorar.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1580.55M;

Console.WriteLine(valorMonetario.ToString("C3", CultureInfo.CreateSpecificCulture("pt-BR")));