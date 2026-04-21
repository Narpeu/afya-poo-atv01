using System;

public class Personagem
{
	public Personagem()
	{
        using System;

namespace Ex04_Projetos
{
    internal class Personagem
    {
        public string Nome { get; private set; }
        public string Classe { get; private set; }
        public int Nivel { get; private set; }
        public int VidaAtual { get; private set; }
        public int VidaMaxima { get; private set; }

        public Personagem(string nome, string classe)
        {
            Nome = nome;
            Classe = classe;
            Nivel = 1;

            if (classe.ToLower() == "guerreiro")
                VidaMaxima = 150;
            else if (classe.ToLower() == "mago")
                VidaMaxima = 80;
            else
                VidaMaxima = 100;

            VidaAtual = VidaMaxima;
        }

        private bool EstaMorto()
        {
            return VidaAtual <= 0;
        }

        public void ReceberDano(int pontos)
        {
            if (EstaMorto()) return;

            VidaAtual -= pontos;

            if (VidaAtual < 0)
                VidaAtual = 0;
        }

        public void Curar(int pontos)
        {
            if (EstaMorto()) return;

            VidaAtual += pontos;

            if (VidaAtual > VidaMaxima)
                VidaAtual = VidaMaxima;
        }

        public void SubirNivel()
        {
            if (EstaMorto()) return;

            Nivel++;

            if (Nivel > 99)
                Nivel = 99;

            VidaMaxima = (int)(VidaMaxima * 1.1);
            VidaAtual = VidaMaxima;
        }

        public void Ressuscitar()
        {
            if (!EstaMorto()) return;

            VidaAtual = VidaMaxima / 2;
        }

        public override string ToString()
        {
            return $"{Nome} ({Classe}) - Lvl {Nivel} - HP: {VidaAtual}/{VidaMaxima}";
        }
    }
}
	}
}
