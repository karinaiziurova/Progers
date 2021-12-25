using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    public class RenderSea
    {
        public static void Render(int[,] field)
        {
            Console.Clear();
            string[] marker = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[] marker1 = { "|  A", "|  Б", "|  В", "|  Г", "|  Д", "|  Е", "|  Ж", "|  З", "|  И", "|  К" };
            Console.Clear();
            Console.Write("|");
            for (int i = 0; i < marker.GetLength(0); i++)
            {
                Console.Write("  " + marker[i] + "\t|");
                ;
            }

            Console.WriteLine();

            string sep = new string('_', field.GetLength(1) * 8 + 1);
            int m = 0;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                //Console.Write(marker[i]+" ");
                Console.WriteLine("____" + sep);
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    if (m < 10 && k == 0)
                    {
                        Console.Write(marker1[m] + "     ");
                        m++;
                    }
                    if (field[i, k] == 0 || field[i, k] == 1 || field[i, k] == 2 || field[i, k] == 3 || field[i, k] == 4)
                    {
                        ToConsole($"|{GetCellView(field[i, k], "▒")}\t", GetColor(field[i, k], ConsoleColor.Blue));
                    }
                    if (field[i, k] == 6)
                    {
                        ToConsole($"|{GetCellView(field[i, k], "x")}\t", GetColor(field[i, k], ConsoleColor.Red));
                    }
                    if (field[i, k] == 5)
                    {
                        ToConsole($"|{GetCellView(field[i, k], "0")}\t", GetColor(field[i, k], ConsoleColor.Green));
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("____" + sep);
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
                case 1:
                    return player;
                case 2:
                    return player;
                case 3:
                    return player;
                case 4:
                    return player;
                case 5:
                    return player;
                case 6:
                    return player;
                default:
                    return player;
            }
        }
    }
}
