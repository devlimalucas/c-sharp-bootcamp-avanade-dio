using ExemploExplorar.Models;
using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach (var linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
