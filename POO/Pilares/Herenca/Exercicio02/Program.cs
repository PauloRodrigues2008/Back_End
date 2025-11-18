using Exercicio02;
Funcionario funcionario = new Funcionario("Carlos", 3000);
Gerente gerente = new Gerente("Ana", 5000, 2000);

Console.WriteLine($"Funcionário: {funcionario.Nome} - Salário: R${funcionario.CalcularSalario():0.00}");
Console.WriteLine($"Gerente: {gerente.Nome} - Salário: R${gerente.CalcularSalario():0.00}");

Console.ReadLine(); 
