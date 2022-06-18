using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA6
{
    internal class Empregado
    {
        public string nome;
        public string cargo;
        public float salarioMensal;
        public float[] valores = { 400.00f, 800.00f, 1200.00f, 2000.00f };
        public float[] qtdnt = { 1.15f, 1.12f, 1.10f, 1.07f, 1.04f };

        public Empregado(string nomeFuncionario, string cargoFuncionario, float salarioFuncionario)
        {
            this.nome = nomeFuncionario;
            this.cargo = cargoFuncionario;
            this.salarioMensal = TrataSalarioNegativo(salarioFuncionario);
            
        }

        private float TrataSalarioNegativo(float salarioRecebido)
        {
            if(salarioRecebido < 0)
            {
                return 0;
            }
            else
            {
                return salarioRecebido;
            }
        }

        public void AumentoSalario()
        {

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($" REAJUSTE SALARIO");
            Console.WriteLine("----------------------------------------------------");


            float salario = this.salarioMensal;

            for (int i = 0; i < qtdnt.Length - 1; i++)
            {
                if (salario < valores[i])
                {
                    this.salarioMensal = this.salarioMensal * qtdnt[i];

                    Console.Write($"Novo salário: {this.salarioMensal}");
                    i = qtdnt.Length;
                }
            }
            if (salario > valores[valores.Length - 1])
            {
                this.salarioMensal = this.salarioMensal * qtdnt[qtdnt.Length - 1];

                Console.Write($"Novo salário: {this.salarioMensal}");
            }
            Console.WriteLine();
        }

        public void ImprimeSalario()
        {
            Console.WriteLine($"Nome do funcionario: {nome}");
            Console.WriteLine($"Cargo do funcionario: {cargo}");
            Console.WriteLine($"Salario do funcionario: {salarioMensal}");
        }

    }
}
