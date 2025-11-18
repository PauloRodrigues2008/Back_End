
namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo;
        private double Taxa = 0.05;

        public override void Depositar(double valor)
        {
              if( valor <= Saldo)
            {
                 System.Console.WriteLine(@$"O valor do saque deve ser maior depósito
                  deve ser maior que R$0,00");
                 return;// para a execução do método por aqui
            }
            Saldo += valor;

           
        }

        public override void Sacar(double valor)
        {                 //valor solicitado + taxa de 1%
            double TotalcomTaxa = valor + (valor/100);
               
         if( valor <=0 || TotalcomTaxa <= Saldo)
            { //Não tem dinheiro na conta
                  System.Console.WriteLine($@" O valor do saque
                   deve positivo e ter dinheiro suficiente para o saque");
                   return; // para a execução do métedo por aqui
            }

            Saldo -= TotalcomTaxa;
        }
    }
}