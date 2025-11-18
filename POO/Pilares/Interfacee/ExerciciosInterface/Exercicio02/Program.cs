using System.Reflection.Metadata;
using Exercicio02;
List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatEdu = new Fatura("Eduardo","Izabel Dark Lab", 50, 1);
// fatEdu.Imprimir();
int opcao;
do
{
    Console.Clear();
    System.Console.WriteLine(@$" Menu de Opções");
System.Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Cadastrar Faturas
5) Cadastrar Relatórios
6) Cadastrar Contratos
0) Sair
Escolher a opção:");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            CadastrarFatura();
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatorio");
            CadastrarContrato();
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            CadastrarRelatorio();
            break;
        case 4:
            Console.WriteLine($"Listar Faturas");
            ListarFatura();
            break;
        case 5:
            Console.WriteLine($"Listar Relatorios");
            ListarRelatorio();
            break;
        case 6:
            Console.WriteLine($"Listar Contratos");
             ListarContrato();
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opcao Invalida");
            break;

    }



System.Console.WriteLine($"Digite <Enter> para continuar ...");
System.Console.ReadLine();

} while (opcao !=0);



void CadastrarFatura()
{
    Console.Write($"Digite o nome do devedor:");
    string dev = Console.ReadLine();
    System.Console.WriteLine($"Digite o nome do credor:");
    string cred = Console.ReadLine();
    System.Console.WriteLine($"Digite o valor da fatura");
    float valor = float.Parse(Console.ReadLine());
    System.Console.WriteLine($"Quantos dias a fatura está em atraso:");
    int DiasDeAtraso = int.Parse (Console.ReadLine());

Fatura f = new Fatura(dev, cred, valor, DiasDeAtraso);
documentos.Add(f);
}


    void CadastrarContrato()
    {
        System.Console.WriteLine($"Digite o nome do  Contratante");
        string con = Console.ReadLine();

        System.Console.WriteLine($"Digite o nome do  Prestador de Serviço");
        string Contratada = Console.ReadLine();

        System.Console.WriteLine($"Digite as Clausulas");
        string txtClausulas = Console.ReadLine();

        //cria o objeto da fatura
        Contrato c = new Contrato(con, Contratada, txtClausulas);
        //cadastro a fatura na lista
        documentos.Add(c);
    }

     void CadastrarRelatorio()
    {
        System.Console.WriteLine($"Digite o nome");
        string no = Console.ReadLine();

        System.Console.WriteLine($"Digite o texto do Relatorio");
        string txtRelatorio = Console.ReadLine();

  //cria o objeto da fatura
        Relatorio r = new Relatorio(no, txtRelatorio);
        //cadastro a fatura na lista
        documentos.Add(r);
    }


void ListarFatura()
{
    System.Console.WriteLine($"Listando as Faturas:");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorio()
{
    System.Console.WriteLine($"Listando os Relatório:");
    foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}

void ListarContrato()
{
    System.Console.WriteLine($"Listando os Contratos:");
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}
 
// Fatura fatZe = new Fatura();
// fatZe.Dono = "Ze da Esquina";
// Fatura fatMaria = new Fatura();
// fatMaria.Dono = "Maria Eduarda";
// Fatura fatEdu = new Fatura();
// fatEdu.Dono = "Eduardo Mendes";
// Fatura fatJoao = new Fatura();
// fatJoao.Dono = "João do pé-de-feijão";
// Fatura fatHenrique = new Fatura();
// fatHenrique.Dono = "Henrique Bucha";
// Fatura fatMarcos = new Fatura();
// fatMarcos.Dono = "Marcos Vinícius";
// Fatura fatFrancisco = new Fatura();
// fatFrancisco.Dono = "Francisco Hugo";
// Fatura fatDavi = new Fatura();
// fatDavi.Dono = "Davi Muniz";
// Fatura fatLucas = new Fatura();
// fatLucas.Dono = "Lucas Marinho";




// listaDeFatura.Add(fatDavi);
// listaDeFatura.Add(fatEdu);
// listaDeFatura.Add(fatFrancisco);
// listaDeFatura.Add(fatHenrique);
// listaDeFatura.Add(fatJoao);
// listaDeFatura.Add(fatLucas);
// listaDeFatura.Add(fatMarcos);
// listaDeFatura.Add(fatMaria);
// listaDeFatura.Add(fatZe);


// foreach (var item in listaDeFatura)
// {
//     item.Imprimir();
// }




// // Relatorio r1 = new Relatorio();
// // r1.Imprimir();
// // Contrato c1 = new Contrato();
// // c1.Imprimir();
// // Fatura f1 = new Fatura();
// // f1.Imprimir();


// List<Relatorio> listadeRelatorio = new List<Relatorio>();

// Relatorio RelDavi = new Relatorio();
// RelDavi.Nome = "Davi Muniz";
// Relatorio RelNegueba = new Relatorio();
// RelNegueba.Nome = "Negueba";

// listadeRelatorio.Add(RelDavi);
// listadeRelatorio.Add(RelNegueba);

// foreach (var item in listadeRelatorio)
// {
//     item.Imprimir();
// }


// List<Contrato> listadeContrato = new List<Contrato>();

// Contrato ConDavi = new Contrato();
// ConDavi.Nome = "Davi muniz";

// Contrato ConNegueba = new Contrato();
// ConNegueba.Nome = "Negueba";

// listadeContrato.Add(ConDavi);
// listadeContrato.Add(ConNegueba);

// foreach (var item in listadeContrato)
// {
//     item.Imprimir();
// }

