using System.Runtime.Serialization;
using ExemploExplorar.Models;

Pessoa p1 = new("Lucas", "Lima");

Pessoa p2 = new("Leonardo", "Buta");

Pessoa p3 = new();

Curso cursoDeIngles = new();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
