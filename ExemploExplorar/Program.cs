using ExemploExplorar.Models;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;


Dictionary<string, string> estados = [];

try
{
    estados.Add("SP", "São Paulo");
    estados.Add("BA", "Bahia");
    estados.Add("MG", "Minas Gerais");

    foreach (var item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ops, ocorreu um erro: {ex.Message}");
}
