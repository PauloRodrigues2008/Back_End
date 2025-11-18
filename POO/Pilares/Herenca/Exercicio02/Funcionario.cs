using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    namespace Exercicio02
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBase;

        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }
    }
}