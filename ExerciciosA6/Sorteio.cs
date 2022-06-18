using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA6
{
    internal class Sorteio
    {
        private int numeroRandomico;
        
        public void SorteioRandomico()
        {
            var rand = new Random();
            this.numeroRandomico = rand.Next(0, 1001);
            int numero = -1;
            int tentativas = 0;

            Console.WriteLine("Adivinhar o número sorteado [1 a 100]. ");

            do
            {


                Console.WriteLine("( Digite 0 para sair do Sorteio Randomico. )");
                Console.WriteLine();
                Console.Write("Digite:");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (numero != 0)
                {
                    tentativas++;

                    if (numero == this.numeroRandomico)
                    {
                        Console.WriteLine($"========================================");
                        Console.WriteLine($"Você acertou em {tentativas} tentativas.");
                        Console.WriteLine($"========================================");
                    }
                    else
                    {
                        
                        Console.WriteLine("Ainda não acertou. Tente novamente.");
                        Console.WriteLine();
                        if (numero < this.numeroRandomico)
                        {
                            Console.WriteLine($"==[ O numero digitado {numero} é MENOR que o numero sorteado.]==");
                        }
                        else
                        {
                            Console.WriteLine($"==[ O numero digitado {numero} é MAIOR que o numero sorteado.]==");
                        }
                        Console.WriteLine();

                    }
                }

            } while (numero != 0);

        }
        
    }
}
