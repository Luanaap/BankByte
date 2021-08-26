using System;
using BankByte.Funcionarios;


namespace BankByte
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario Pedro = new Designer("833.222.048-39");
            Pedro.Nome = "Pedro";

            Funcionario Roberta = new Diretor("159.753.398-04");
            Roberta.Nome = "Roberta";

            Funcionario Igor = new Auxiliar("981.198.778-53");
            Igor.Nome = "Igor";

            Funcionario Camila = new GerenteDeConta("326.985.628-89");
            Camila.Nome = "Camila";

            Funcionario Luana = new GerenteDeConta("587.458.752-66");
            Luana.Nome = "Luana";

            gerenciadorBonificacao.Registrar(Pedro);
            gerenciadorBonificacao.Registrar(Roberta);
            gerenciadorBonificacao.Registrar(Igor);
            gerenciadorBonificacao.Registrar(Camila);
            gerenciadorBonificacao.Registrar(Luana);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
