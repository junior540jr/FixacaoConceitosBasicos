using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal SalarioBruto { get; set; }
        public int AnosEmpresa { get; set; }

        public decimal CalcularSalarioLiquido()
        {
            decimal salarioLiquido = SalarioBruto * 0.90m;

            if (AnosEmpresa > 5)
            {
                salarioLiquido += 200m;
            }

            return salarioLiquido;
        }
    }
}
