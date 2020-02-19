using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.saldo = 1000;

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.saldo = 1000;

            contaDaGabriela.Transferir(500, contaDoBruno);

            Console.WriteLine("Saldo Conta Gabriela: R$" + contaDaGabriela.saldo);
            Console.WriteLine("Saldo Conta Bruno: R$" + contaDoBruno.saldo);
            Console.ReadLine();
        }
    }
}
