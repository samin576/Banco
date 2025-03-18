
using System;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaBancaria pessoa = new ContaBancaria();
                Console.WriteLine("Digite o seu nome:");
                pessoa.Titular = Console.ReadLine();
                Console.WriteLine("Digite o seu saldo:");
                pessoa.Saldo = double.Parse(Console.ReadLine());
                TipoConta();
                int tipoConta = int.Parse(Console.ReadLine());
                if (tipoConta == 1)
                {
                    pessoa = new ContaPoupanca(pessoa.Titular, pessoa.Saldo);
                }
                else
                {
                    pessoa = new ContaCorrente(pessoa.Titular, pessoa.Saldo);
                }
                Escolha();
                int escolha = int.Parse(Console.ReadLine());
                Valor(escolha);
                double escolha2 = int.Parse(Console.ReadLine());
                Operacao(escolha, pessoa, escolha2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Você fez algo errado! {e.Message}");
            }




        }
        static void TipoConta()
        {
            Console.WriteLine("""
                Qual é o tipo da conta?
                1-Poupança
                2-Corrente
                """);
        }
        static void Escolha()
        {
            Console.WriteLine("""
                Você gostaria de sacar ou depositar? 
                1-Sacar
                2-Depositar
                """);
        }
        static void Valor(int n1)
        {
            if (n1 == 1)
            {
                Console.WriteLine("Digite a quantia que deseja sacar");
            }
            else if (n1 == 2)
            {
                Console.WriteLine("Digite a quantia que deseja depositar");
            }
        }
        static void Operacao(int escolhaOperacao, ContaBancaria pessoa, double Quantia)
        {
            if (escolhaOperacao == 1)
            {

                pessoa.Sacar(Quantia);
                pessoa.ExibirSaldo();
            }
            else if (escolhaOperacao == 2)
            {

                pessoa.Depositar(Quantia);
                pessoa.ExibirSaldo();
            }
            else
            {
                Console.WriteLine("Opção não válida!");
            }
        }
    }
}