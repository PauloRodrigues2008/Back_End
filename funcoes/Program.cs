Console.Clear();
Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"ok, {nome}! Agora vamos dar as boas vindas a você!!");

Console.WriteLine($"Por Favor escolha uma opção abaixo");
Console.WriteLine($"    1 - Saudar com nome");
Console.WriteLine($"    2 - Saudar com sobrenome");
Console.WriteLine($"    3 - Saudar com nome e Sobrenome");
Console.WriteLine($"    0 - Apenas Saudação Genérica");
Console.Clear();

int opcao = 0;
switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudarComNome(nome);
        break;

    case 2:
        SaudarComSobrenome(sobrenome);
        break;

    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja Bem vindo {nomeCompleto}");
        break;
    default:
        break;
}

void SaudarComSobrenome(string sobrenomeRecebido)
{
     Console.WriteLine($"Olá, seja bem-vindo {sobrenomeRecebido}");
}


// Função que escreva uma saudação de forma genérica
void SaudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia");
}

// Recebe um nome e escreve uma saudação personalizada
void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}


//Recebe dois parametros e devolve um texto - recebe nome e sobrenome e devolve o nome completo
string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return $"{nomeRecebido} {sobrenomeRecebido}";
}