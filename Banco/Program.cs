
using System;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria pessoa = new ContaBancaria();
            pessoa.TipoOperacao();
            Escolha();
            int escolha = int.Parse(Console.ReadLine());
            Valor(escolha);
            double escolha2 = int.Parse(Console.ReadLine());
            Operacao(escolha, pessoa, escolha2);


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
                pessoa.TipoOperacao();
                pessoa.Sacar(Quantia);
                pessoa.ExibirSaldo();
            }
            else if (escolhaOperacao == 2)
            {
                pessoa.TipoOperacao();
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