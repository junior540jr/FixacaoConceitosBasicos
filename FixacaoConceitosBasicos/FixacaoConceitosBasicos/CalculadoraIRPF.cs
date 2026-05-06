using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class CalculadoraIRPF
    {
        public void CalcularIRPF()
        {
            try
            {
                Console.Write("Informe sua renda mensal (R$): ");
                decimal renda = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe o número de dependentes: ");
                int dependentes = Convert.ToInt32(Console.ReadLine());

                // Dedução por dependente (valor aproximado usado em 2015: R$ 189,59)
                decimal deducaoDependente = 189.59m;
                renda -= dependentes * deducaoDependente;

                decimal imposto = 0;
                decimal parcelaDeduzir = 0;
                decimal aliquota = 0;

                if (renda <= 1903.98m)
                {
                    aliquota = 0;
                    parcelaDeduzir = 0;
                }
                else if (renda <= 2826.65m)
                {
                    aliquota = 7.5m;
                    parcelaDeduzir = 142.80m;
                }
                else if (renda <= 3751.05m)
                {
                    aliquota = 15m;
                    parcelaDeduzir = 354.80m;
                }
                else if (renda <= 4664.68m)
                {
                    aliquota = 22.5m;
                    parcelaDeduzir = 636.13m;
                }
                else
                {
                    aliquota = 27.5m;
                    parcelaDeduzir = 869.36m;
                }

                imposto = (renda * (aliquota / 100)) - parcelaDeduzir;
                if (imposto < 0) imposto = 0;

                Console.WriteLine($"\nRenda ajustada: R$ {renda:F2}");
                Console.WriteLine($"Alíquota aplicada: {aliquota}%");
                Console.WriteLine($"Parcela a deduzir: R$ {parcelaDeduzir:F2}");
                Console.WriteLine($"Valor de IRPF devido: R$ {imposto:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Digite apenas números.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: Valor informado é muito grande.");
            }
            finally
            {
                Console.WriteLine("\nCálculo finalizado.");
            }
        }
    }
}
