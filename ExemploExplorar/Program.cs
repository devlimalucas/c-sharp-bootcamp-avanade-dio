using ExemploExplorar.Models;
using System.Globalization;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = [];

Venda v1 = new(id: 1, produto: "Material de escritório", preco: 20.30M, dataAtual);
Venda v2 = new(id: 2, produto: "Licença de Software", preco: 200.56M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
