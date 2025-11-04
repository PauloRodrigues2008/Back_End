

namespace ClasseEObjetos
{
    public class AgênciaBancária
    {
        public string Título = "";
        public string Saldo = "";


        public void depositar()
        {
             System.Console.WriteLine($"Dinheiro depositado");
        }
        public void sacar()
        {
             System.Console.WriteLine($"Dinheiro sacado");
        }
    }
}