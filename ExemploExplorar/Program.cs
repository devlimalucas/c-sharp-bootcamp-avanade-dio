using ExemploExplorar.Models;
using System.Data;
using System.Globalization;

string dataString = "2022-12-17 18:00";

DateTime.TryParseExact(dataString,
                      "yyyy-MM-dd HH:mm",
                      CultureInfo.InvariantCulture,
                      DateTimeStyles.None,
                      out DateTime data);

Console.WriteLine(data);
