using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class JogoAdivinhacao
    {
        public void Iniciar()
        {
            try
            {
                Random random = new Random();
                int numeroSecreto = random.Next(0, 101); 
                int tentativas = 10;
                bool acertou = false;

                Console.WriteLine("Você tem 10 chances para adivinhar um número entre 0 e 100.");

                for (int i = 1; i <= tentativas; i++)
                {
                    Console.Write($"\nTentativa {i}: Digite seu palpite: ");
                    int palpite = Convert.ToInt32(Console.ReadLine());

                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número!");
                        acertou = true;
                        break;
                    }
                    else if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior.");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor.");
                    }
                }

                if (!acertou)
                {
                    Console.WriteLine($"\nSuas chances acabaram. O número secreto era: {numeroSecreto}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite apenas números inteiros.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: Valor informado é muito grande.");
            }
            finally
            {
                Console.WriteLine("\nFim do jogo.");
            }
        }
    }
}