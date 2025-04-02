using System;
namespace Daniel_e_Matheus___RPG_de_Turnos;

class Program
{
    static void Main(string[] args)
    {
        string escolha;
        Console.WriteLine("~ MENU ~");
        Console.WriteLine("Criar um personagem ou sair do jogo? 1- Criar, 2- Sair");
        escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Personagem Char = new Personagem();
            Char.criacaoPersonagem();

            Itens Equips = new Itens();
            Equips.cadastrarItem();

            Mapa maps = new Mapa();
            maps.mapa();

        }
        else if (escolha == "2")
        {
            Console.Clear();
        }
    }
}
