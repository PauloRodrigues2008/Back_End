/*
Faça um programa que pergunte para o usuário a quantidade de números que ele 
quer digitar. após isso crie um laço que exiba o número que o usuário digitar apenas
sefor PAR, Utilize a estrutura WHILE. 
*/



//perguntar quantos números o usuário quer digitar
//criar um laço while baseado na quantidade de números que o usuário quer digitar
//dentro do laço, verificar se é par e imprimir $"Número digitado é par : {nDigitado}"


    int quantidade, contador = 1, n;

        Console.WriteLine("Quantos números você deseja digitar?");
        quantidade = int.Parse(Console.ReadLine());

while (contador <= quantidade)
{
    Console.WriteLine($"Digite o {contador}º número:");
    n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
    {
        Console.WriteLine($"Número digitado é par: {n}");

    }
    contador++;
}
        