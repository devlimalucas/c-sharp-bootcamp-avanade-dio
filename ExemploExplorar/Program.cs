using ExemploExplorar.Models;
using System.Data;
using System.Globalization;

string dataString = "2022-02-170 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
                      "yyyy-MM-dd HH:mm",
                      CultureInfo.InvariantCulture,
                      DateTimeStyles.None,
                      out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");

}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}
