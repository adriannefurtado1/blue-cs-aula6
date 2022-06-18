namespace ExerciciosA6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A6E1JogoDaVelha();
            //A6E2GerenciandoSalarios();
            //A6E3FaturadeServico();
            //A6E4Sorteio();
            //A6E5ManipulaString();

        }

        static void A6E1JogoDaVelha()
        {
            JogoDaVelha jogoDaVelha = new JogoDaVelha();
            int operacao = 0;
            bool fimJogo = false;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("                   JOGO DA VELHA                  ");
            Console.WriteLine("--------------------------------------------------");

            do
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Incluir jogadores.                                        *");
                Console.WriteLine("* 2 - Exibir o tabuleiro com status do jogo.                    *");
                Console.WriteLine("* 3 - Jogar.                                                    *");
                Console.WriteLine("* 4 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();
                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        jogoDaVelha.IncluirJogadores();
                        break;
                    case 2:
                        jogoDaVelha.ExibirStatusTabuleiro();
                        break;
                    case 3:
                        jogoDaVelha.Jogar();
                        jogoDaVelha.tabuleiro = new char[,] {{ ' ', ' ', ' '},
                                                             { ' ', ' ', ' '},
                                                             { ' ', ' ', ' '}};
                        jogoDaVelha.nomes = new string[,] { { "X", "O" }, { "Jogador X", "Jogador O" } };

                        break;
                    case 4:
                        fimJogo = true;
                        break;
                    default:
                        break;
                }
            } while (!fimJogo);
        }

        static void A6E2GerenciandoSalarios()
        {
            string nome;
            string cargo;
            float salario;
            int operacao;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("                GERENCIANDO SALÁRIOS              ");
            Console.WriteLine("--------------------------------------------------");


            Console.WriteLine();

            Console.Write("Informe o nome do empregado: ");
            nome = Console.ReadLine();

            Console.Write("Informe o cargo do empregado: ");
            cargo = Console.ReadLine();

            Console.Write("Informe o salário do empregado: ");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Empregado empregado = new Empregado(nome, cargo, salario);

            do
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Aumento Salário.                                          *");
                Console.WriteLine("* 2 - Imprimir Salário.                                         *");
                Console.WriteLine("* 3 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();
                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        empregado.AumentoSalario();
                        break;
                    case 2:
                        empregado.ImprimeSalario();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (operacao != 3);


        }

        static void A6E3FaturadeServico()
        {

            int operacao;
            double numero = 0;
            double quantidade = 0;
            string descricao = "";
            float preco = 0.00f;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("                FATURA DE SERVIÇOS                ");
            Console.WriteLine("--------------------------------------------------");

            do
            {
                Console.WriteLine();
                Console.WriteLine("*****************************************************************");
                Console.WriteLine("* Escolha a operação?                                           *");
                Console.WriteLine("* 1 - Incluir Fatura                                            *");
                //Console.WriteLine("* 2 - Alterar Fatura                                            *");
                Console.WriteLine("* 4 - Sair.                                                     *");
                Console.WriteLine("*****************************************************************");
                Console.WriteLine();
                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                if (operacao == 1)
                {
                    Console.WriteLine("[ INCLUIR FATURA - TIPO 1]");

                    Console.Write("Informe o numero da fatura: ");
                    numero = double.Parse(Console.ReadLine());

                    Console.Write("Informe a descrição do produto: ");
                    descricao = Console.ReadLine();

                    Console.Write("Informe a quantidade comprada: ");
                    quantidade = double.Parse(Console.ReadLine());

                    Console.Write("Informe o preço: ");
                    preco = float.Parse(Console.ReadLine());

                    FaturaDeServico faturaDeServico = new FaturaDeServico(numero, descricao, quantidade, preco);

                    Console.WriteLine();
                    Console.WriteLine();

                    faturaDeServico.CalculaValorFatura();

                }



            } while (operacao != 4);

        }

        static void A6E4Sorteio()
        {

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("               .S.O.R.T.E.I.O.                    ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            Sorteio sorteio = new Sorteio();
            sorteio.SorteioRandomico();

        }

        static void A6E5ManipulaString()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("              MANIPULA STRINGS                    ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            ManipulaStrings manipulaStrings = new ManipulaStrings();

        }

    }


}