
//cria um array tamanho 4 e preenche com vazio
string[] nomes = new string[4];//tamanho é 4 - 0 a 3
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;

/*
nomes[0] = "Gustavo";
idades[0] = 20;

nomes[1] = "Paulo";
idades[1] = 16;

nomes[2] = "Matheus";
idades[2] = 17;

nomes[3] = "Hugo";
idades[3] = 17;

nomes[3] = "joão";
idades[3] = 23;

*/

do
{
    Console.Clear();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos   ");
    Console.WriteLine($"0) Sair            ");
    Console.WriteLine($"Digite a opção     ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função correta 
    switch (opcao)
    {
        case 0:
          Console.WriteLine("Encerrando ...");
          Console.WriteLine("Precione <Enter> para encerrar ...");
            Console.WriteLine();
            break;

        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"opção Inválida, pressione <Enter> para continuar ...");
            Console.WriteLine();//parar o sistema e esperar o úsuario digitar Enter!!
            break;

    }//Fim do switch

} while (opcao != 0);

// ============ Funções =============

void CadastrarAluno()
{
    //vericar se tem espaço no array para cadastrar (totalAlunos)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        return;
    }
    //Pedir os dados para o úsuarios (nome,idade)
    Console.WriteLine($"Digite o Nome do Aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    //guardar/cadastrar no array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;
    
    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pessione <Enter> para continuar");
    Console.WriteLine();//parar o sistema e esperar o úsuari da <Enter>


}


void ListarAlunos()
{

    Console.WriteLine();
    Console.WriteLine($"Resultado");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"  Nomes: {nomes[i]}");
        Console.WriteLine($"  Idades: {idades[i]} anos");
        Console.WriteLine();
    }

}




//Função para exibir os alunos

void ListarAluno()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}");
        Console.WriteLine($"Nome: {idades[i]} alunos");
        Console.WriteLine();

    }

}