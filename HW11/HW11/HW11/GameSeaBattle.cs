using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class GameSeaBattle
    {
        SailorPlayer SailorPlayer1 = new SailorPlayer(null);  
        SailorPlayer SailorPlayer2 = new SailorPlayer(null);

        PlayerField PlayerField1 = new PlayerField();
        PlayerField PlayerField2 = new PlayerField();


        public void Game()
        {
            
            string x;
            int y;
            SetParamPlayer(SailorPlayer1, PlayerField1);
            Console.Clear();
            SetParamPlayer(SailorPlayer2, PlayerField2);
            bool game = true;
            bool shoot;
            while (game)
            {
                
                do
                {
                    shoot = true;
                    RenderSea.Render(SailorPlayer2.SeaField);
                    Console.WriteLine($"{SailorPlayer1.Name} стреляй: \n x->");
                    x = Console.ReadLine();
                    Console.WriteLine($"y-> ");
                    y = int.Parse(Console.ReadLine());
                    SetShoot(x, y, SailorPlayer2.SeaField);
                    RenderSea.Render(SailorPlayer2.SeaField);
                    GetWin(SailorPlayer1);
                    shoot = GetShoot(x, y, SailorPlayer2.SeaField, shoot);
                    
                } while (shoot);
                Console.Write("Смена сторони, нажмите любую клавишу для продолжения игры: ");
                Console.ReadKey();

                do
                {
                    shoot = true;
                    RenderSea.Render(SailorPlayer1.SeaField);
                    Console.WriteLine($"{SailorPlayer2.Name} стреляй: \n x->");
                    x = Console.ReadLine();
                    Console.WriteLine($"y-> ");
                    y = int.Parse(Console.ReadLine());
                    SetShoot(x, y, SailorPlayer1.SeaField);
                    RenderSea.Render(SailorPlayer1.SeaField);
                    GetWin(SailorPlayer2);
                    shoot = GetShoot(x, y, SailorPlayer1.SeaField, shoot);

                } while (shoot);
                Console.Write("Смена сторони, нажмите любую клавишу для продолжения игры: ");
                Console.ReadKey();
            }

        }
        public bool GetShoot(string x, int y, int[,] field, bool shoot)
        {
            string[] marker1 = { "A", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "К" };
            string[] marker2 = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "к" };
            int k = 0;
            int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < marker1.Length; i++)
            {
                if (marker1[i] == x || marker2[i] == x)
                {
                    k = i;
                }
            }

            if (field[k, y - 1] == 6)
            {
                Console.WriteLine("Попали, нажмите 'ENTER' для продолжения: ");
                Console.ReadLine();
                shoot = true;
            }
            if(field[k, y - 1] != 6)
            {
                Console.WriteLine("Промазали, нажмите 'ENTER' для продолжения: ");
                Console.ReadLine();
                shoot = false;
            }

            return shoot;
        }

        public bool GetWin(SailorPlayer sailorPlayer)
        {
            bool game = true;
            int count = 0; 
            for (int i = 0; i < sailorPlayer.SeaField.GetLength(0); i++)
            {
                for (int j = 0; j < sailorPlayer.SeaField.GetLength(1); j++)
                {
                    if (sailorPlayer.SeaField[i, j] == 1 || sailorPlayer.SeaField[i, j] == 2 || sailorPlayer.SeaField[i, j] == 3 || sailorPlayer.SeaField[i, j] == 4)
                    {
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                game = false;
                Console.WriteLine($"{sailorPlayer.Name} вы победили!!!");
                return game; 
            }
            return game;
        }
        public SailorPlayer SetParamPlayer(SailorPlayer sailorPlayer,PlayerField playerField)
        {
            Console.Write("Матрос назови свое имя: ");
            sailorPlayer.Name = Console.ReadLine();
            bool startShip = true;
            do
            {
                Console.Write($"{sailorPlayer.Name} выбери растановку кораблей, нажми пробел: ");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    playerField.GetPrintMatrix(1);
                    Console.Write($"1 - да, 2 - нет: ");
                    int n = int.Parse(Console.ReadLine());
                    startShip = n == 1 ? startShip = false : startShip = true;
                    continue;
                }
                else
                {
                    Console.Clear();
                    Console.Write($"Не та кнопка, {sailorPlayer.Name} нажмите любю кулавишу:");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            } while (startShip);
            
            sailorPlayer.SeaField = playerField.field;
            return sailorPlayer;
        }
        public int[,] SetShoot(string x, int y, int[,] field)
        {
            string[] marker1 = { "A", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "К" };
            string[] marker2 = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "к" };
            int k = 0;
            int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < marker1.Length; i++)
            {
                if(marker1[i]==x || marker2[i]==x)
                {
                    k = i;
                }       
            }

            if (field[k, y - 1] == 0)
            {
                field[k, y - 1] = 5;
            }
            if (field[k, y - 1] == 1 || field[k, y - 1] == 2 || field[k, y - 1] == 3 || field[k, y - 1] == 4)
            {
                field[k, y - 1] = 6;
            }

            return field;
        }
    }
}
