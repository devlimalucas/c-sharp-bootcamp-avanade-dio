using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using ExemploPOO.Models;

Aluno a1 = new();

a1.Nome = "Lucas Lima";
a1.Idade = 30;

Aluno a2 = new();

a2.Nome = "Kleber Filho";
a2.Idade = 40;

a1.Apresentar();
a2.Apresentar();
