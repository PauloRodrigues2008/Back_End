int opcao = -1, totalClientes = 0;
string[] nomes = new string[3];
double[] saldos = new double[3];

Console.Clear();

do
{
    Console.WriteLine("=========AGÊNCIA BANCARIA, BEM VINDO(A)=========");
    Console.WriteLine();
    Console.WriteLine("Bem vindo(a) a nossa agência Bancaria, o que deseja realizar?");
    Console.WriteLine();
    Console.WriteLine(" 1. Cadastrar cliente");
    Console.WriteLine(" 2. Depositar        ");
    Console.WriteLine(" 3. Sacar            ");
    Console.WriteLine(" 4. Transferir       ");
    Console.WriteLine(" 5. Listar Clientes  ");
    Console.WriteLine(" 0. Sair             ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar nosso Sistema Bancario, Encerrando...");
            Console.WriteLine("Aperte <ENTER> para continuar...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();

            Console.WriteLine();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        default:
          Console.WriteLine($"Opção Inválida, pressione <ENTER> para continuar");
          Console.WriteLine();
            break;
    }

} while (opcao != 0);

void CadastrarCliente()
{
//Verificar se tem espaço no array para cadastrar
    if (totalClientes >= 3)
    {
        Console.WriteLine(" Limite de ocupação atingido");
        Console.WriteLine($"Pressione <ENTER> para continuar...");
        Console.ReadLine();
        return;
    }
   
   //Cadastra o cliente
    Console.Write($"Nome do Cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine("Cadastrado com sucesso...");
    Console.WriteLine();

    Console.WriteLine("Aperte <ENTER> para continuar...");
    Console.WriteLine();
    Console.ReadLine();
}

void Depositar()
{

    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado!");

    Console.WriteLine("Aperte <ENTER> para continuar...");
    Console.WriteLine();
}

void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    //pedir o valor do saque 
    Console.Write($"Valor do saque: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    //validar se pode sacar ou não 
    if (saldos[idCliente] >= valorSolicitado)
    {
        saldos[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saque realizado com sucesso!");
    } else
    {
        Console.WriteLine($"Saldo insuficiente");
    }
    
    Console.WriteLine("Aperte <ENTER> para continuar...");
    Console.WriteLine();
}

void Transferir()
{
    Console.WriteLine($"== Transfência ==");
    Console.WriteLine($"Conta de origem:");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }
    Console.Write($" Conta de Origem:");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }
    Console.Write($"Valor para transferir:");
    double valor = double.Parse(Console.ReadLine());
    
    if(saldos[idClienteOrigem] >= valor)
    {
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        Console.WriteLine($"Transferência concluída!");

    } else
    {
        Console.WriteLine($"Saldo insuficiente!");
    }

}

void ListarClientes()
{
    Console.WriteLine("======LISTA DE CLIENTES======");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($" {i} - {nomes[i]} | Saldo: R${saldos[i]}");
        Console.WriteLine();
    }

    Console.WriteLine("Aperte <ENTER> para continuar...");
    Console.WriteLine();
    Console.ReadLine();
}

int BuscarCliente()
{
    ListarClientes();
    Console.WriteLine($"Digite o número do cliente:");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return idCliente;//Aqui vai ser devolvido o id do cliente (Indice do array onde ele está cadastrado)
}