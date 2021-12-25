using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSeaBattle a = new GameSeaBattle();
           a.Game();
            //int[,] field = new int[10, 10];
            //for (int i = 0; i < field.GetLength(0); i++)
            //{
            //    for (int j = 0; j < field.GetLength(1); j++)
            //    {
            //        field[i, j] = 0;
            //    }
            //}

            //field[0, 4] = 3;
            //field[1, 4] = 3;
            //field[2, 4] = 3;

            //field[4, 4] = 3;
            //field[5, 4] = 3;
            //field[6, 4] = 3;

            //field[3, 6] = 4;
            //field[4, 6] = 4;
            //field[5, 6] = 4;
            //field[6, 6] = 4;

            //field[0, 2] = 2;
            //field[1, 2] = 2;

            //field[3, 2] = 2;
            //field[4, 2] = 2;

            //field[6, 2] = 2;
            //field[7, 2] = 2;

            //field[0, 0] = 1;
            //field[2, 0] = 1;
            //field[4, 0] = 1;
            //field[6, 0] = 1;
            //Render(field);


        }
        static void Render(int[,] field)
        {
            string[] marker = { "0","1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[] marker1 = {"|  A", "|  Б", "|  В", "|  Г", "|  Д", "|  Е", "|  Ж", "|  З", "|  И", "|  К" };
            Console.Clear();
            Console.Write("|");
            for (int i = 0; i < marker.GetLength(0); i++)
            {
                Console.Write(" " + marker[i] + "\t|");
;           }

            Console.WriteLine();

            string sep = new string('_', field.GetLength(1) * 8 + 1);
            int m = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                //Console.Write(marker[i]+" ");
                Console.WriteLine("____"+sep);
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    if (m <10 && k==0)
                    {
                        Console.Write(marker1[m]+"     ");
                        m++; 
                    }
                    if (field[i, k] == 0 || field[i, k] == 1 || field[i, k] == 2 || field[i, k] == 3 || field[i, k] == 4)
                    {
                        ToConsole($"|{GetCellView(field[i, k], Convert.ToString(field[i, k]))}\t", GetColor(field[i, k], ConsoleColor.Green));
                    }
                    else
                    {
                        ToConsole($"|{GetCellView(field[i, k], "O")}\t", GetColor(field[i, k], ConsoleColor.Red));
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("____"+sep);
        }
        static ConsoleColor GetColor(int n, ConsoleColor color)
        {
            if (n == 5)
            {
                return color;
            }
            else
            {
                return color;
            }
            ConsoleColor result = ConsoleColor.White;

            return result;
        }
        static void ToConsole(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ResetColor();
        }

        static string GetCellView(int value, string player = "")
        {
            switch (value)
            {
                case 5:
                    return player;
                default:
                    return player;
            }
        }

    }
}
