// 1. Classe Animal
// Crie uma classe abstrata chamada Animal com os métodos fazerSom() e Mover().
// Crie duas classes derivadas: Cachorro e Gato. Cada uma deve implementar os métedos de forma diferente.
using Exemplos;

// Cachorro c1 = new Cachorro ();
// c1.FazerSom();
// c1.Mover();

// Gato g1 = new Gato();
// g1.FazerSom();
// g1.Mover();

// Pessoal p1 = new Pessoal();
// p1.FazerSom();
// p1.Mover();

ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

Console.WriteLine($"Saldo Conta Corrente antes do saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupanca antes do saque: R${cp.Saldo}");

cc.Sacar(10);
cp.Sacar(5);

Console.WriteLine();

Console.WriteLine($"Saldo Conta Corrente apos o saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupanca apos o saque: R${cp.Saldo}");

