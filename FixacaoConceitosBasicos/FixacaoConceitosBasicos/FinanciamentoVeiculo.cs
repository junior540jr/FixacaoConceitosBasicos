using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class FinanciamentoVeiculo
    {
        public void CalcularFinanciamento()
        {
            try
            {
                Console.Write("Informe o valor do veículo (R$): ");
                decimal valorVeiculo = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe o total de parcelas: ");
                int parcelas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe a taxa mensal (%): ");
                decimal taxaMensal = Convert.ToDecimal(Console.ReadLine()) / 100;
                               
                decimal valorTotal = valorVeiculo * (decimal)Math.Pow((double)(1 + taxaMensal), parcelas);

                Console.WriteLine($"\nValor total pago pelo veículo: R$ {valorTotal:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nCálculo financiamento finalizado.");
            }
        }
    }
}

