using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class Aposentadoria
    {
        public void CalcularAposentadoria()
        {
            try
            {
                Console.Write("Informe sua idade atual: ");
                int idadeAtual = Convert.ToInt32(Console.ReadLine());

                Console.Write("Com quantos anos pretende se aposentar: ");
                int idadeAposentadoria = Convert.ToInt32(Console.ReadLine());

                Console.Write("Valor que pretende guardar mensalmente (R$): ");
                decimal depositoMensal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Taxa de rendimento mensal (%): ");
                decimal taxaMensal = Convert.ToDecimal(Console.ReadLine()) / 100;

                int meses = (idadeAposentadoria - idadeAtual) * 12;
                                
                decimal montante = depositoMensal * ((decimal)Math.Pow((double)(1 + taxaMensal), meses) - 1) / taxaMensal;
                                
                decimal rendaMensal = montante * taxaMensal;

                Console.WriteLine($"\nMontante acumulado: R$ {montante:F2}");
                Console.WriteLine($"Renda mensal estimada: R$ {rendaMensal:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nCálculo aposentadoria finalizado.");
            }
        }
    }
}
