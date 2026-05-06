using FixacaoConceitosBasicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class GestorFuncionarios
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void CadastrarFuncionarios()
        {
            try
            {
                Console.Write("Quantos funcionários deseja cadastrar? ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine($"\nCadastro do funcionário {i + 1}:");

                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Salário bruto (R$): ");
                    decimal salarioBruto = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Anos de empresa: ");
                    int anosEmpresa = Convert.ToInt32(Console.ReadLine());

                    Funcionario f = new Funcionario
                    {
                        Nome = nome,
                        Idade = idade,
                        SalarioBruto = salarioBruto,
                        AnosEmpresa = anosEmpresa
                    };

                    funcionarios.Add(f);
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
            foreach (var f in funcionarios)
            {
                Console.WriteLine($"Nome: {f.Nome}, Idade: {f.Idade}, Salário Bruto: R$ {f.SalarioBruto:F2}, " +
                                  $"Salário Líquido: R$ {f.CalcularSalarioLiquido():F2}");
            }
        }
    }
}

