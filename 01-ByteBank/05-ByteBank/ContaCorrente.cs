// using _04_ByteBank;

namespace _05_ByteBank
{
    public class ContaCorrente
    {
        //public _4_ByteBank.Cliente nome;
        public Cliente Titular {get; set;}
        public int agencia { get; set; }
        public int numeroConta { get; set; }
        private double _saldo = 100;

        public bool Sacar(double valor)
        {
            if (valor > this._saldo)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > this._saldo)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                contaDestino.Depositar(valor);
                return true;
            }
        }
        
        public double Saldo
        {
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
            get
            {
                return _saldo;
            }
        }
    }
}
