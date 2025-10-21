/*
Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time)
e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
*/

int time1, time2;

        Console.Write("Gols do time 1: ");
        time1 = int.Parse(Console.ReadLine());

        Console.Write("Gols do time 2: ");
        time2 = int.Parse(Console.ReadLine());

        if (time1 > time2)
            Console.WriteLine("Time 1 ganhador");
        else if (time2 > time1)
            Console.WriteLine("Time 2 ganhador");
        else
            Console.WriteLine("Empate");
