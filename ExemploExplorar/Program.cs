using ExemploExplorar.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1580.55M;

double porcentagem = .3421;

int numero = 123456;

Console.WriteLine(valorMonetario.ToString("N2"));

Console.WriteLine(porcentagem.ToString("P"));

Console.WriteLine(numero.ToString("##-##-##"));
