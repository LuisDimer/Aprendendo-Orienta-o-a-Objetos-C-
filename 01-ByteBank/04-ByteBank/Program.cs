using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.CPF = "030.444.330-10";
            gabriela.profissao = "Desenvolvedor";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.numeroConta = 164863;
            conta.agencia = 863;
            conta.saldo = 1000;

            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
