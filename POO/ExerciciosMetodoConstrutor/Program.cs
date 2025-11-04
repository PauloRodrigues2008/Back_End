using ExerciciosMetodoConstrutor;

// Carro c1 = new Carro("Toyota", "Corolla", 2022);
// c1.ExibirDados();
// Console.WriteLine();




// Aluno aluno1 = new Aluno("Paulo", 9.5);
//  System.Console.WriteLine($"Digite o seu Nome ");
// aluno1.Nome = Console.ReadLine();
//  System.Console.WriteLine($"Digite a sua Nota");
//  aluno1.Nota = int.Parse(Console.ReadLine());

//  System.Console.WriteLine (@$"Terceira Pessoa cadastrada:)
//  ");


// Aluno aluno2 = new Aluno("Andre", 7.5);
//  aluno1.ExibirDados();
// // aluno2.ExibirDados();
// // Console.WriteLine();

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Hugo";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Samuel";
a2.Media();
