namespace ClassesEObjetos
{
    public class produtocomDesconto
    {
        
  
        public string nome;
        public double preco;

        //Métodos
        
        public void AplicarDesconto(double percentual)
        {
            double desconto = preco * (percentual / 100);

            preco -= desconto;

            Console.WriteLine($"Desconto de {percentual}% aplicado!");
            Console.WriteLine($"Novo preço do produto {nome}: R$ {preco:F2}");
        }
    }
}