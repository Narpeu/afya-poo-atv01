using System;

public class Conta
{
	public Conta()
	{
        using System;

class Conta
    {
        private double saldo = 0;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
                saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente");
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo: {saldo}");
        }
    }
}
}
