using System;

public class Cofre
{
	public Cofre()
	{
        using System;

class Cofre
    {
        private string senha = "1234";

        public void Abrir(string tentativa)
        {
            if (tentativa == senha)
                Console.WriteLine("Cofre aberto");
            else
                Console.WriteLine("Senha incorreta");
        }
    }
}
}
