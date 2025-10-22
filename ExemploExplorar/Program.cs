using ExemploExplorar.Models;
using System.Globalization;

try
{
    string[] linhas = File.ReadAllLines("Arquivosa/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch(Exception ex)
{
    Console.WriteLine($"Ops, ocorreu um erro: {ex.Message}");
}
