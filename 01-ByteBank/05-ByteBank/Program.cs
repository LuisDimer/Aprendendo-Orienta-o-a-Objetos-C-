using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.titular= "Guilherme";

            conta.Saldo = -5000;

            Console.WriteLine(conta.Titular);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
