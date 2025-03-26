using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace RPGPorTurnos
{
    public class Mapa
    {
        string destino;
        public void Cidade()
        {
            do
            {
                Console.WriteLine("Você está na Cidade");
                Console.WriteLine("Suas opções de rotas são:");
                Console.WriteLine("");
                Console.WriteLine("1 - Deserto");
                Console.WriteLine("2 - Porto");
                Console.WriteLine("3 - Minas Abandonadas");
                Console.WriteLine("");
                Console.WriteLine("Para onde gostaria de ir?");
                destino = Console.ReadLine();
            } while (destino != "Deserto" && destino != "Porto" && destino != "Minas Abandonadas");
            if (destino == "Floresta")
            {
                Deserto();
                Console.ReadKey();
            }
            else if (destino == "Porto")
            {
                Porto();
                Console.ReadKey();
            }
            else
            {
                MinasAbandonadas();
                Console.ReadKey();
            }
        }
        public void Deserto()
        {
            do
            {
                Console.WriteLine("Você está na Floresta");
                Console.WriteLine("Suas opções de rotas são:");
                Console.WriteLine("");
                Console.WriteLine("1 - Cidade");
                Console.WriteLine("");
                Console.WriteLine("Para onde gostaria de ir?");
                destino = Console.ReadLine();
            } while (destino != "Cidade");
            if (destino == "Cidade Alvorada")
            {
                Cidade();
                Console.ReadKey();
            }
        }
        public void Porto()
        {
            do
            {
                Console.WriteLine("Você está no Porto de Alvorada");
                Console.WriteLine("Suas opções de rotas são:");
                Console.WriteLine("");
                Console.WriteLine("1 - Ilha");
                Console.WriteLine("2 - Cidade");
                Console.WriteLine("");
                Console.WriteLine("Para onde gostaria de ir?");
                destino = Console.ReadLine();
            } while (destino != "Ilha" && destino != "Cidade");
            if (destino == "Floresta")
            {
                Ilha();
                Console.ReadKey();
            }
            else
            {
                Cidade();
                Console.ReadKey();
            }
        }
        public void Ilha()
        {
            do
            {
                Console.WriteLine("Você está na Ilha");
                Console.WriteLine("Suas opções de rotas são:");
                Console.WriteLine("");
                Console.WriteLine("1 - Porto");
                Console.WriteLine("");
                Console.WriteLine("Para onde gostaria de ir?");
                destino = Console.ReadLine();
            } while (destino != "Vila de Cartol");
            if (destino == "Vila de Cartol")
            {
                Porto();
                Console.ReadKey();
            }
        }
        public void MinasAbandonadas()
        {
            do
            {
                Console.WriteLine("Você está na Ilha");
                Console.WriteLine("Suas opções de rotas são:");
                Console.WriteLine("");
                Console.WriteLine("1 - Cidade");
                Console.WriteLine("");
                Console.WriteLine("Para onde gostaria de ir?");
                destino = Console.ReadLine();
            } while (destino != "Cidade");
            if (destino == "Cidade")
            {
                Cidade();
                Console.ReadKey();
            }
        }
    }
}
