/*
 Escreva um programa que leia as medidas dos lados de um triângulo e escreva se
 ele é Equilátero, Isósceles ou Escaleno. Sendo que: 
 
   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes.

*/


double l1, l2, l3;

Console.WriteLine("Digite o primeiro lado do triângulo:");
l1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo:");
l2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo:");
l3 = double.Parse(Console.ReadLine());

if ((l1 < l2 + l3) && (l2 < l1 + l3) && (l3 < l1 + l2))
{
    if (l1 == l2 && l2 == l3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (l1 == l2 || l1 == l3 || l2 == l3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("As medidas informadas não formam um triângulo.");
}

