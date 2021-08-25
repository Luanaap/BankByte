using System;
using BankByte.Funcionarios;


namespace BankByte
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Carlos = new Funcionario();
            Carlos.Nome = "Carlos";
            Carlos.CPF = "546.879.157-20";
            Carlos.Salario = 2000;

            gerenciador.Registrar(Carlos);

            Diretor Roberta = new Diretor();
            Roberta.Nome = "Roberta";
            Roberta.CPF = "454.658.148-3";
            Roberta.Salario = 5000;

            Funcionario RobertaTeste = Roberta;

            Console.WriteLine("Bonificação de uma referencia de Diretor:  " + Roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionario:  " + RobertaTeste.GetBonificacao());


            gerenciador.Registrar(Roberta);

            //double totalBonificacoes = Carlos.GetBonificacao();
            //totalBonificacoes += Roberta.GetBonificacao();

            Console.WriteLine(Carlos.Nome);
            Console.WriteLine(Carlos.GetBonificacao());

            Console.WriteLine(Roberta.Nome);
            Console.WriteLine(Roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
