using ExemploExplorar.Models;
using System.Globalization;

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeiturra.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ops, arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ops, caminho da pasta não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ops, ocorreu um erro: {ex.Message}");
}
