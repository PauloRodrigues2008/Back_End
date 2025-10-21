int numero1;
int numero2;


Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("O " + (numero1) + " é maior");
}
else
{
    Console.WriteLine("O " + (numero2) + " é maior");
}


int n1, n2;

Console.WriteLine("Digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro numero é maior:" + n1);

}
else if (n1 < n2)
{
    Console.WriteLine($"O segundo numero é maior: {n2}");
}
else
{
    Console.WriteLine($"Os números {n1} e {n2} são iguais");
}

