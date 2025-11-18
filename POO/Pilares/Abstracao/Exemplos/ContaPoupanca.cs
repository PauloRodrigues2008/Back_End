
namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
         public double Saldo;
        private double Taxa = 5;
        public override void Depositar(double valor)
        {
          if (valor <= 0 )
          {
            Console.WriteLine($"O valor do saque deve ser maior que R$ 0,00");
            return;
          }

        Saldo += valor;

        }

        public override void Sacar(double valor)
        {

            double totalcomTaxa = valor + (valor * Taxa);

            if (valor <= 0 || totalcomTaxa <= Saldo)
            {
               Console.WriteLine($"Total com taxa poupanca {totalcomTaxa}");
               return;
            }

            Saldo -= totalcomTaxa;
        }
    }
}