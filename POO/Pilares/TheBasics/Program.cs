using TheBasics;
Console.Clear();

// //arry/lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();




// //Endereco
// Endereco enderecoPa = new Endereco();
// enderecoPa.Logradouro = "Rua niterói";
// // Pesooa com endereco
// Pessoa Pa = new Pessoa(enderecoPa);
// Pa.Nome = "Paulo";
// Pa.Idade = 20;

// //***************Davi**********
// //Endereco
// Endereco endDavi = new Endereco();
// endDavi.Logradouro = "Rua la de casa";
// //Pessoa com endereco
// Pessoa Davi = new Pessoa(endDavi);
// Davi.Nome = "Davi";
// Davi.Idade = 17;

// //guardando os dados na lista
// peoples.Add(Pa);
// peoples.Add(Davi);

// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endMat = new Endereco();
// endMat.Logradouro = "spínola";
// endMat.Numero = 300;
// Aluno Matheus = new Aluno(endMat);
// Matheus.Curso = "Desenvolvimento de Sistemas";
// Matheus.RA = "1456 - xpto";
// Matheus.NotaFinal = 10;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua la de casa";
// endProfAlex.Numero = 987;

// Professor profAlex = new Professor(endProfAlex);
// profAlex.Nome = "Aléxia Victória";

// Console.WriteLine($"{Matheus.Nome} Estudos na turma {Matheus.Curso} da profa. {profAlex.Nome}");


Carro fusca = new Carro();
fusca.Marca = "wolksvagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Domianar 400";

fusca.Ligar();
fusca.AbrirPortaMala();


dominar400.Ligar();
dominar400.Empinar();
