using ExemploExplorar.Models;
using System.Globalization;
using Newtonsoft.Json;

Venda v1 = new(id: 1, produto: "Material de escritório", preco: 20.30M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

Console.WriteLine(serializado);