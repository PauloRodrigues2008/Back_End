/*
As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem
compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas,
calcule e escreva o valor total da compra
*/


Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preco;

        // Verifica se foram compradas pelo menos 12 maçãs
        if (quantidade >= 12)
        {
            preco = 0.25;
        }
        else
        {
            preco = 0.30;
        }

        // Calcula o valor total
        double total = quantidade * preco;

        // Exibe o resultado
        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");