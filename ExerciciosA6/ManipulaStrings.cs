using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosA6
{
    internal class ManipulaStrings
    {
        public string textoDigitado = "";

        public ManipulaStrings()
        {
            Menu();
        }

        public void Menu()
        {
            int operacao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Abreviar Nome                                             *");
                Console.WriteLine("* 2 - Inverter string                                           *");
                Console.WriteLine("* 3 - Contar vogais e consoantes.                               *");
                Console.WriteLine("* 4 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();

                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        this.Abrevia();
                        break;
                    case 2:
                        this.Inverte();
                        break;
                    case 3:
                        this.ConteVogaisConsoantes();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (operacao != 4);


    }

        public void RecebeTexto(string Mensagem)
        {
            Console.WriteLine();
            Console.Write($"{Mensagem}");
            
            this.textoDigitado = Console.ReadLine();

        }

        public void Abrevia()
        {
            string saldoTexto;
            string variavelAuxiliar = "";
            string resultado = "";

            RecebeTexto("Digite o nome a ser abreviado: ");

            do
            {
                int espacoIndex = this.textoDigitado.IndexOf(" ");
                int tamanhoTextoDigitado = this.textoDigitado.Length;

                if (espacoIndex != -1 || tamanhoTextoDigitado > 0)
                {
                    if (espacoIndex != -1)
                    {
                        variavelAuxiliar = this.textoDigitado.Substring(0, espacoIndex);
                    }
                    else
                    {
                        variavelAuxiliar = this.textoDigitado;
                    }

                    if (variavelAuxiliar.Length > 2)
                    {
                        resultado += variavelAuxiliar.Substring(0, 1) + ". ";
                    }
                    else
                    {
                        resultado += variavelAuxiliar + " ";
                    }

                    if (espacoIndex != -1)
                    {
                        this.textoDigitado = this.textoDigitado.Substring(espacoIndex + 1, tamanhoTextoDigitado - espacoIndex - 1);
                    }
                    else
                    {
                        this.textoDigitado = "";
                    }

                }
            } while (this.textoDigitado.Length > 0);

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }

        public void Inverte()
        {
            char[] phraseAsChars;
            string resultado = "";
            
            RecebeTexto("Digite o texto a ser invertido: ");
            
            phraseAsChars = this.textoDigitado.ToCharArray();
            
            for(int i = phraseAsChars.Length; i > 0; i--)
            {
                resultado += phraseAsChars[i-1];
            }

            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }

        public void ConteVogaisConsoantes()
        {
            char[] phraseAsChars;
            string vogais= "aeiouAEIOU";
            string numeros = "1234567890 ";
            int qtdVogais = 0;
            int qtdConsoantes = 0;

            RecebeTexto("Digite o texto: ");
            
            phraseAsChars = this.textoDigitado.ToCharArray();
            
            for(int i = 0; i < phraseAsChars.Length; i++)
            {
                
                this.textoDigitado.IndexOf(" ");
                if (vogais.IndexOf(phraseAsChars[i]) > -1)
                {
                    qtdVogais++;
                }
                else if (numeros.IndexOf(phraseAsChars[i]) == -1 )
                {
                    qtdConsoantes++;
                }

            }
            Console.WriteLine($"Total de vogais: {qtdVogais}");
            Console.WriteLine($"Total de consoantes: {qtdConsoantes}");

            Console.ReadLine();

        }

    }
}
