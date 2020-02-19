public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numeroConta;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (valor > this.saldo)
        {
            return false;
        }
        else
        {
            saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (valor > this.saldo)
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
}