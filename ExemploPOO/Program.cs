using System.Runtime.Serialization;
using ExemploPOO.Models;

ContaCorrente c1 = new(123, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();
c1.Sacar(10000);
