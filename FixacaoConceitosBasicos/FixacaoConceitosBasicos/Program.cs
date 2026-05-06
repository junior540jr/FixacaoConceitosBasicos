using MeuProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {            
            CalculadoraIRPF calc = new CalculadoraIRPF();
            calc.CalcularIRPF();

            JogoAdivinhacao jogo = new JogoAdivinhacao();
            jogo.Iniciar();

            FinanciamentoVeiculo financiamento = new FinanciamentoVeiculo();
            financiamento.CalcularFinanciamento();

            Aposentadoria apos = new Aposentadoria();
            apos.CalcularAposentadoria();

            GestorFuncionarios gestorFuncionarios = new GestorFuncionarios();
            gestorFuncionarios.CadastrarFuncionarios();

            GestorAlunos gestorAlunos = new GestorAlunos();
            gestorAlunos.CadastrarAlunos();

            JogoDaVelha jogoVelha = new JogoDaVelha();
            jogoVelha.Iniciar();
        }
    }

    public class CalculadoraIRPF
    {
        public void CalcularIRPF()
        {
            return;
        }
    }

    public class JogoAdivinhacao
    {
        public void Iniciar()
        {
            return;
        }
    }
    public class FinanciamentoVeiculo
    {
        public void CalcularFinanciamento()
        {
            return;
        }
    }
    public class Aposentadoria
    {
        public void CalcularAposentadoria()
        {
            return;
        }
    }
    public class GestorFuncionarios
    {
        public void CadastrarFuncionarios()
        {
            return;
        }
    }
    public class GestorAlunos
    {
        public void CadastrarAlunos()
        {
            return;
        }
    }
    public class jogoVelha
    {
        public void Iniciar()
        {
            return;
        }
    }

}
