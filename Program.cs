using PraticaSala;
using System.Globalization;

Veiculo novoVeiculo = new Veiculo();

novoVeiculo.Ano = 2003;
novoVeiculo.Modelo = "Uno";
novoVeiculo.Cor = "Prata";
System.Console.WriteLine($"Veículo Modelo: {novoVeiculo.Modelo}, Cor:{novoVeiculo.Cor}, Ano: {novoVeiculo.Ano}, Idade: {novoVeiculo.IdadeVeiculo}");

Aluno novoAluno = new Aluno();
System.Console.WriteLine($"Aluno Nome: {novoAluno.Nome}, Idade:{novoAluno.Idade}");

Agenda agenda = new Agenda();
Contato n1 = new Contato();
n1.Nome = "Lorena";
n1.CPF = "00352442590";

Contato n2 = new Contato();
n2.Nome = "Moana";
n2.CPF = "00352442590";

Contato n3 = new Contato();
n3.Nome = "Carlos";
n3.CPF = "017721";


