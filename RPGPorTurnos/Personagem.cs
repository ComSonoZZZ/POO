using System;
using System.Collections.Generic;
using System.Text;

namespace RPGPorTurnos
{
    public class Personagem
    {
        string nome;
        string classe;
        int pontosdevida;
        int pontosdeenergia;
        int ataque;
        int resistencia;
        int nivel;
        int experiencia;
        int vidapornivel;
        int energiapornivel;

        public void criacaoPersonagem()
        {
            Console.WriteLine("Insira o nome do seu personagem");
            nome = Console.ReadLine();
            Console.Clear();

            do
            {
                Console.WriteLine("CLASSES DISPONÍVEIS");
                Console.WriteLine("");
                Console.WriteLine("1 - GUERREIRO");
                Console.WriteLine("2 - ARQUEIRO");
                Console.WriteLine("3 - MAGO");
                Console.WriteLine("4 - MONGE");
                Console.WriteLine("");
                Console.WriteLine("Escreva qual a classe do seu personagem.");
                classe = Console.ReadLine();

            } while (classe != "GUERREIRO" && classe != "ARQUEIRO" && classe != "MAGO" && classe != "MONGE");

            Console.Clear();
            Console.WriteLine("Bem-Vindo " + nome + " você pertence a classe " + classe + " seus atributos são:");
            if (classe == "GUERREIRO")
            {
                construirGuerreiro();
                Console.ReadKey();
            }
            else if (classe == "ARQUEIRO")
            {
                construirArqueiro();
                Console.ReadKey();
            }
            else if (classe == "MAGO")
            {
                construirMago();
                Console.ReadKey();
            }
            else
            {
                construirMonge();
                Console.ReadKey();
            }
        }

        public void construirGuerreiro()
        {
            pontosdevida = 200;
            pontosdeenergia = 50;
            ataque = 10;
            resistencia = 10;
            nivel = 1;
            experiencia = 0;
            vidapornivel = 25;
            energiapornivel = 5;
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Vida recebida por nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por nível: " + energiapornivel);
        }

        public void construirArqueiro()
        {
            pontosdevida = 125;
            pontosdeenergia = 125;
            ataque = 14;
            resistencia = 6;
            nivel = 1;
            experiencia = 0;
            vidapornivel = 15;
            energiapornivel = 15;
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Vida recebida por nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por nível: " + energiapornivel);
        }

        public void construirMago()
        {
            pontosdevida = 75;
            pontosdeenergia = 175;
            ataque = 16;
            resistencia = 4;
            nivel = 1;
            experiencia = 0;
            vidapornivel = 5;
            energiapornivel = 25;
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Vida recebida por nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por nível: " + energiapornivel);
        }

        public void construirMonge()
        {
            pontosdevida = 150;
            pontosdeenergia = 100;
            ataque = 8;
            resistencia = 12;
            nivel = 1;
            experiencia = 0;
            vidapornivel = 20;
            energiapornivel = 10;
            Console.WriteLine("Pontos de Vida: " + pontosdevida);
            Console.WriteLine("Pontos de Energia: " + pontosdeenergia);
            Console.WriteLine("Ataque: " + ataque);
            Console.WriteLine("Resistência: " + resistencia);
            Console.WriteLine("Nível: " + nivel);
            Console.WriteLine("Exp: " + experiencia);
            Console.WriteLine("Vida recebida por nível: " + vidapornivel);
            Console.WriteLine("Energia recebida por nível: " + energiapornivel);
        }
    }
}
