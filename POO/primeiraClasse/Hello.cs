namespace PrimeiraClasse
{
    public class Hello
    {

        // Propriedades/Características - variáveis internas dessa classe
        public string TextoHello = "";

        // Métedos/Comportamentos/Ações - são as funções internas dessa classe
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }
        public void SaldarcomNome(string n)
        {
            Console.WriteLine($"olá {n}");
        }
    } // fim da classe
}//fim do namespace
