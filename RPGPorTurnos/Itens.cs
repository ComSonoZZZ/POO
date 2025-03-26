using System;

namespace RPGPorTurnos
{
    public class Itens
    {

        string[,] equipamentos = new string[21, 6];
        public void cadastrarItem()
        {
            equipamentos[0, 0] = "ITEM";
            equipamentos[0, 1] = "TIPO";
            equipamentos[0, 2] = "VALOR";
            equipamentos[0, 3] = "DANO";
            equipamentos[0, 4] = "DEFESA";
            equipamentos[0, 5] = "SLOTS";

            equipamentos[1, 0] = "Adaga";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "3";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Espada Curta";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "6";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Espada Longa";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "10";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Bastão";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "7";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Lança";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "6";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Machado";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "7";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Pá";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "10";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Cimitarra";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "8";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Arco";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "2";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Cajado";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "6";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[1, 0] = "Túnica";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "5";
            equipamentos[1, 5] = "1";


            equipamentos[1, 0] = "Elmo de Placas";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "15";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Peitoral de Placas";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "20";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Calça de Placas";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "17";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Bota de Placas";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "14";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Peitoral de Cota de Malha";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "25";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Calça de Cota de Malha";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "20";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Peitoral de Couro";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "10";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Escudo de Madeira";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "10";
            equipamentos[1, 5] = "2";

            equipamentos[1, 0] = "Escudo de Ferro";
            equipamentos[1, 1] = "Armadura";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "0";
            equipamentos[1, 4] = "18";
            equipamentos[1, 5] = "2";

            listarItens();
        }

        public void listarItens()
        {
            Console.Clear();
            Console.WriteLine(equipamentos);
        }
    }
}
