//Faça um programa que receba 3 números inteiros e imprima na tela
// a somatória total dos números.

        int numero, soma = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Digite o {i}º número inteiro:");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }

        Console.WriteLine($"A somatória total dos números é: {soma}");