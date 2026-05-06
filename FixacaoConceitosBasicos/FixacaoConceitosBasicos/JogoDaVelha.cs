using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos
{
    public class JogoDaVelha
    {
        private char[,] tabuleiro = new char[3, 3];
        private char jogadorAtual = 'X';

        public void Iniciar()
        {
            InicializarTabuleiro();

            for (int jogada = 0; jogada < 9; jogada++)
            {
                ExibirTabuleiro();

                Console.WriteLine($"\nVez do jogador {jogadorAtual}");
                Console.Write("Informe a linha (0-2): ");
                int linha = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a coluna (0-2): ");
                int coluna = Convert.ToInt32(Console.ReadLine());

                if (tabuleiro[linha, coluna] == ' ')
                {
                    tabuleiro[linha, coluna] = jogadorAtual;

                    if (VerificarVencedor())
                    {
                        ExibirTabuleiro();
                        Console.WriteLine($"\nJogador {jogadorAtual} venceu!");
                        return;
                    }

                    jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Posição já ocupada, tente novamente.");
                    jogada--; 
                }
            }

            ExibirTabuleiro();
            Console.WriteLine("\nJogo terminou sem vencedores.");
        }

        private void InicializarTabuleiro()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tabuleiro[i, j] = ' ';
        }

        private void ExibirTabuleiro()
        {
            Console.WriteLine("\nTabuleiro:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---+---+---");
            }
        }

        private bool VerificarVencedor()
        {            
            for (int i = 0; i < 3; i++)
                if (tabuleiro[i, 0] != ' ' &&
                    tabuleiro[i, 0] == tabuleiro[i, 1] &&
                    tabuleiro[i, 1] == tabuleiro[i, 2])
                    return true;
                     
            for (int j = 0; j < 3; j++)
                if (tabuleiro[0, j] != ' ' &&
                    tabuleiro[0, j] == tabuleiro[1, j] &&
                    tabuleiro[1, j] == tabuleiro[2, j])
                    return true;
                        
            if (tabuleiro[0, 0] != ' ' &&
                tabuleiro[0, 0] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 2])
                return true;

            if (tabuleiro[0, 2] != ' ' &&
                tabuleiro[0, 2] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[2, 0])
                return true;

            return false;
        }
    }
}
