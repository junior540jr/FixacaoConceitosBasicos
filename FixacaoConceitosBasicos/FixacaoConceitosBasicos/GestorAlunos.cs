using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos;

namespace MeuProjeto
{
    public class GestorAlunos
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void CadastrarAlunos()
        {
            try
            {
                Console.Write("Quantos alunos deseja cadastrar? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine($"\nCadastro do aluno {i + 1}:");

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nota 1: ");
                    decimal nota1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Nota 2: ");
                    decimal nota2 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Nota 3: ");
                    decimal nota3 = Convert.ToDecimal(Console.ReadLine());

                    Aluno aluno = new Aluno
                    {
                        Nome = nome,
                        Idade = idade,
                        Nota1 = nota1,
                        Nota2 = nota2,
                        Nota3 = nota3
                    };

                    alunos.Add(aluno);
                }

                ExibirResultados();
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Digite apenas números quando solicitado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nCadastro finalizado.");
            }
        }

        private void ExibirResultados()
        {
            Console.WriteLine("\n--- Resultados ---");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Média: {aluno.CalcularMedia():F2}, Situação: {aluno.Situacao()}");
            }
        }
    }
}
