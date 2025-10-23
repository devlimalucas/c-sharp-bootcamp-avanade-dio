using ExemploExplorar.Models;
using System.Globalization;
using Newtonsoft.Json;

List<Venda> listaVendas = [];

Venda v1 = new(id: 1, produto: "Material de escritório", preco: 20.30M);
Venda v2 = new(id: 2, produto: "Licença de Software", preco: 200.56M);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);