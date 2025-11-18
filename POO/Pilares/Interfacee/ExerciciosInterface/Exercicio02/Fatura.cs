

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor =0;
        public int DiasDeAtraso = 0;
        public float Juros = 0.10f;

       public Fatura( string dev, string cred, float val, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = val;
            DiasDeAtraso = qtdAtraso;
        }


        public void Imprimir()
        {
             CalcularValorDivida();


            System.Console.WriteLine(@$"
            Credor: {Credor}
            Devedor{Devedor}
            Dias de atraso: {DiasDeAtraso} dia(s)
            Valor: R${Valor:F2}
            Juros: R${(Juros * DiasDeAtraso):F2}
            Total Com júros: {Valor:F2}            
            ");

        }

        public void CalcularValorDivida()
        {
           if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
           if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA ");
            }
         
        }
    }
}