using System;

namespace RPGPorTurnos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogoAtivo = true;

            while (jogoAtivo)
            {
                // Exibe o menu de opções
                Console.Clear();
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1 - Iniciar um novo jogo");
                Console.WriteLine("2 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Chama o método de criação de personagem
                        Personagem Char = new Personagem();
                        Char.criacaoPersonagem();
                        break;

                    case "2":
                        // Sai do programa
                        Console.WriteLine("Saindo do jogo...");
                        jogoAtivo = false;
                        break;

                    default:
                        // Opção inválida
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }

    // Classe de exemplo para o Personagem
    public class Personagem
    {
        public void criacaoPersonagem()
        {
            // Lógica de criação de personagem
            Console.WriteLine("\nCriando um novo personagem...");
            // Você pode adicionar interações com o usuário aqui, por exemplo:
            Console.Write("Digite o nome do personagem: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Personagem {nome} criado com sucesso!\n");

            // Pode adicionar mais atributos do personagem aqui
        }
    }
}
