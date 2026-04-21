using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace Ex04_Projetos
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Personagem p = new Personagem("Arthas", "Guerreiro");

                Console.WriteLine(p);

                p.ReceberDano(50);
                Console.WriteLine(p);

                p.Curar(30);
                Console.WriteLine(p);

                p.SubirNivel();
                Console.WriteLine(p);

                p.ReceberDano(999);
                Console.WriteLine(p);

                p.Curar(20); // não funciona porque morreu
                Console.WriteLine(p);

                p.Ressuscitar();
                Console.WriteLine(p);
            }
        }
    }
}
    }
}
