using PraticaSala;
using System.Globalization;

Veiculo novoVeiculo = new Veiculo();

novoVeiculo.Ano = 2003;
novoVeiculo.Modelo = "Uno";
novoVeiculo.Cor = "Prata";
System.Console.WriteLine($"Veículo Modelo: {novoVeiculo.Modelo}, Cor:{novoVeiculo.Cor}, Ano: {novoVeiculo.Ano}, Idade: {novoVeiculo.IdadeVeiculo}");

Aluno novoAluno = new Aluno();
System.Console.WriteLine($"Aluno Nome: {novoAluno.Nome}, Idade:{novoAluno.Idade}");

