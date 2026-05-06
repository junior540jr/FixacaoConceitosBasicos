using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixacaoConceitosBasicos;

namespace MeuProjeto
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }

        public decimal CalcularMedia()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public string Situacao()
        {
            decimal media = CalcularMedia();

            if (media >= 7.0m)
                return "Aprovado";
            else if (media >= 5.0m)
                return "Recuperação";
            else
                return "Reprovado";
        }
    }
}
