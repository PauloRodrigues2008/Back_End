using MetadoConstrutor;

// Pualo é uma variavel tipo Pessoa
//Pessoa Paulo = new Pessoa( "Walyson", 17 );

// //Paulo.Nome = "Paulo Andre";
// //Paulo.Idade = 17;

// System.Console.WriteLine(@$"O objeto pessoa que criei é o {Paulo.Nome} com a idade
//  {Paulo.Idade}");

// //Paulo.Nome = "Davi muniz";



// //Paulo.Nome = "gustavinho";
// Paulo.ExibirDados();

// System.Console.WriteLine($"{Paulo.Nome}");

//primeiro metedo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();
System.Console.WriteLine(@$"Primeira Pessoa cadastrada:
                     Nome{PrimeiraPessoa.Nome}
                     Idade:{PrimeiraPessoa.Idade}

");
//segundo metedo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");
System.Console.WriteLine(@$"Segunda Pessoa cadastrada:
                     Nome{SegundaPessoa.Nome}
                     Idade:{SegundaPessoa.Idade}

");

//terceiro metedo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);

System.Console.WriteLine("Digite o nome da terceira pessoa");
TerceiraPessoa.Nome = Console.ReadLine();

System.Console.WriteLine($"Digite a idade da terceira pessoa");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());


System.Console.WriteLine(@$"Terceira Pessoa cadastrada:
                     Nome{TerceiraPessoa.Nome}
                     Idade:{TerceiraPessoa.Idade}


");
System.Console.WriteLine();




