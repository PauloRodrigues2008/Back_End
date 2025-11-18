// Exercício 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma
// No Retângulo utilizar o cálculo = Largura * Altura;
// No Círculo utilizar o cálculo = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI


// Retângulo
using Exercicio01;

System.Console.WriteLine($"====== Bem vindo ao progroma Cálculos de Geometria ======");
System.Console.WriteLine();

System.Console.WriteLine($" Vamos calcular");

//Altura e Largura
System.Console.WriteLine($"Digite a largura do Retângulo: ");

float l = float.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite a Altura do Retângulo");

float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine($"Agora vamos calcular a área do círculo");


System.Console.WriteLine($"Informe o raio do círculo");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine($"Fim do programa");
System.Console.WriteLine();

