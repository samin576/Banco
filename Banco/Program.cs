
using System;
using System.ComponentModel.Design;
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
                switch (tipoConta)
                {
                    case 1:
                        pessoa = new ContaPoupanca(pessoa.Titular, pessoa.Saldo);
                        break;
                    case 2:
                        pessoa = new ContaCorrente(pessoa.Titular, pessoa.Saldo);
                        break;
                    default:
                        Console.WriteLine("Opção não válida");
                        break;
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
            switch (n1)
            {
                case 1:
                    Console.WriteLine("Digite a quantia que deseja sacar");
                    break;
                case 2:
                    Console.WriteLine("Digite a quantia que deseja depositar");
                    break;
                default:
                    Console.WriteLine("Opção não válida!");
                    break;
            }
        }
        static void Operacao(int escolhaOperacao, ContaBancaria pessoa, double Quantia)
        {
            switch (escolhaOperacao)
            {
                case 1:
                    pessoa.Sacar(Quantia);
                    pessoa.ExibirSaldo();
                    break;
                case 2:
                    pessoa.Depositar(Quantia);
                    pessoa.ExibirSaldo();
                    break;
                default:
                    Console.WriteLine("Opção não válida!");
                    break;

            }
        }
    }
}