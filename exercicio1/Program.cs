/*
Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela
“Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” 
se o valor gasto ultrapassar o valor do salário.
*/

double salario = 0.0, g = 0.0;

Console.WriteLine("Informe o salário recebido");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total gasto");
g = double.Parse(Console.ReadLine());

if(salario > g)
{
    Console.WriteLine("Gastos dentro do orçamento");
} else
{
    Console.WriteLine("Orçamento estourado");
}

