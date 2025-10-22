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

    Console.WriteLine("-----------");

    estados.Remove("MG");
    estados["SP"] = "São Paulo - valor alterado";

    foreach (var item in estados)
    {
        Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    }

    Console.WriteLine("-----------");

    string chave = "BA";

    if (estados.ContainsKey(chave))
    {
        Console.WriteLine($"O valor existente: {chave}");
    }
    else
    {
        Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
    }

}
catch (Exception ex)
{
    Console.WriteLine($"Ops, ocorreu um erro: {ex.Message}");
}
