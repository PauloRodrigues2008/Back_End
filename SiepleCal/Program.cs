/*
Pedir o nome do usuário
pedir dois números e mostrar a soma dos números no final


*/
string nome;
int numero1;
int numero2;

/*
pedir os nomes pro usuários
*/
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();


//Pedir os dois números
Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

//somar os dois números
int soma = numero1 + numero2;

//Exibir nome e a soma
Console.WriteLine(nome);
Console.WriteLine(soma);
