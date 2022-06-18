namespace ExerciciosA6
{
    internal class JogoDaVelha
    {
        public char[,] tabuleiro;
        public string[,] nomes;
        private char selecao;
        private char[] possibilidades = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private int[,] matrizpossibilidades = { { 2, 0 }, { 2, 1 }, { 2, 2 },
                                                { 1, 0 }, { 1, 1 }, { 1, 2 },
                                                { 0, 0 }, { 0, 1 }, { 0, 2 } };


        //método construtor da classe
        public JogoDaVelha()
        {
            
            this.tabuleiro = new char[,] {
                                            { ' ', ' ', ' '},
                                            { ' ', ' ', ' '},
                                            { ' ', ' ', ' '}
                                        };

            this.nomes = new string[,] { { "X", "O" }, { "Jogador X", "Jogador O" } };

        }

        public void IncluirJogadores()
        {
            Console.Write("Informe o nome do jogador X: ");
            nomes[1,0] = Console.ReadLine();
            Console.Write("Informe o nome do jogador O: ");
            nomes[1,1] = Console.ReadLine();
        }

        public void ExibirStatusTabuleiro()
        {
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("= Veja o Tabuleiro =");
            Console.WriteLine("====================");
            Console.WriteLine();
            Console.WriteLine($" 7 | 8 | 9      {tabuleiro[0,0]} | {tabuleiro[0,1]} | {tabuleiro[0,2]} ");
            Console.WriteLine($"---|---|---    ---|---|---  ");
            Console.WriteLine($" 4 | 5 | 6      {tabuleiro[1,0]} | {tabuleiro[1,1]} | {tabuleiro[1,2]} ");
            Console.WriteLine($"---|---|---    ---|---|---  ");
            Console.WriteLine($" 1 | 2 | 3      {tabuleiro[2,0]} | {tabuleiro[2,1]} | {tabuleiro[2,2]} ");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void Jogar()
        {
            int posicaoInformada;
            bool fimjogo = false;
            string campeao = "";
            int qtdjog = 0;




            this.ExibirStatusTabuleiro();

            while (!fimjogo)
            {
                do
                {

                    Console.Write($"Jogador {nomes[0, (qtdjog % 2)]} - {nomes[1, qtdjog % 2]} - Em que posição deseja jogar? ");

                    selecao = Char.Parse(Console.ReadLine());

                    posicaoInformada = Array.IndexOf(possibilidades, selecao);

                    if (posicaoInformada < 0)
                    {
                        Console.Write("Valor inválido, digite novamente: ");
                    }

                    else if (tabuleiro[matrizpossibilidades[posicaoInformada, 0], matrizpossibilidades[posicaoInformada, 1]] != ' ')
                    {
                        Console.Write("Lugar já está preenchido, escolha outro lugar: ");
                    }

                } while (posicaoInformada < 0 || tabuleiro[matrizpossibilidades[posicaoInformada, 0], matrizpossibilidades[posicaoInformada, 1]] != ' ');

                tabuleiro[matrizpossibilidades[posicaoInformada, 0], matrizpossibilidades[posicaoInformada, 1]] = (qtdjog % 2) == 0 ? 'X' : 'O';
                qtdjog++;

                this.ExibirStatusTabuleiro();

                if ((tabuleiro[2, 0] == 'X' && tabuleiro[2, 1] == 'X' && tabuleiro[2, 2] == 'X') ||
                    (tabuleiro[1, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[1, 2] == 'X') ||
                    (tabuleiro[0, 0] == 'X' && tabuleiro[0, 1] == 'X' && tabuleiro[0, 2] == 'X') ||
                    (tabuleiro[0, 0] == 'X' && tabuleiro[1, 0] == 'X' && tabuleiro[2, 0] == 'X') ||
                    (tabuleiro[0, 1] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 1] == 'X') ||
                    (tabuleiro[0, 2] == 'X' && tabuleiro[1, 2] == 'X' && tabuleiro[2, 2] == 'X') ||
                    (tabuleiro[0, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[2, 2] == 'X') ||
                    (tabuleiro[2, 0] == 'X' && tabuleiro[1, 1] == 'X' && tabuleiro[0, 2] == 'X'))
                {
                    campeao = "X - " + nomes[1, 0];
                    fimjogo = true;
                }
                else if ((tabuleiro[2, 0] == 'O' && tabuleiro[2, 1] == 'O' && tabuleiro[2, 2] == 'O') ||
                         (tabuleiro[1, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[1, 2] == 'O') ||
                         (tabuleiro[0, 0] == 'O' && tabuleiro[0, 1] == 'O' && tabuleiro[0, 2] == 'O') ||
                         (tabuleiro[0, 0] == 'O' && tabuleiro[1, 0] == 'O' && tabuleiro[2, 0] == 'O') ||
                         (tabuleiro[0, 1] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 1] == 'O') ||
                         (tabuleiro[0, 2] == 'O' && tabuleiro[1, 2] == 'O' && tabuleiro[2, 2] == 'O') ||
                         (tabuleiro[0, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[2, 2] == 'O') ||
                         (tabuleiro[2, 0] == 'O' && tabuleiro[1, 1] == 'O' && tabuleiro[0, 2] == 'O'))
                {
                    campeao = "O - " + nomes[1, 1];
                    fimjogo = true;
                }

                if (qtdjog == 9)
                {
                    fimjogo = true;
                }

                if (fimjogo )
                {
                    if(campeao != "")
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"************************************");
                        Console.WriteLine($"  {campeao} GANHOU  !!!!");
                        Console.WriteLine($"************************************");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($"************************************");
                        Console.WriteLine($"     ::[DEU VELHA]::      ");
                        Console.WriteLine($"          :ó(  ");
                        Console.WriteLine($"************************************");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

            }


        }
    }
}
