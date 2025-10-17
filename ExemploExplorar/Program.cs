using System.Runtime.Serialization;
using ExemploExplorar.Models;

Pessoa p1 = new();
p1.Nome = "Lucas";
p1.Sobrenome = "Lima";

Pessoa p2 = new();
p2.Nome = "Leo";
p2.Sobrenome = "Leo";

Curso cursoDeIngles = new();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
