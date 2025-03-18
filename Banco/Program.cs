using Banco;
using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria pessoa = new ContaBancaria(7, "samin", 700);
            Console.WriteLine("Digite um valor para depositar:");
            int quantidade = int.Parse(Console.ReadLine());
            pessoa.Depositar(quantidade);
            pessoa.ExibirSaldo();
        }
    }
}