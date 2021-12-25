using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    class PlayerField
    {
        public int[,] field = new int[10, 10];
        public int oneShip = 4;
        public int twoShip = 3;
        public int three = 2;
        public int four = 1;

        public int[,] getNullField()
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = 0;
                }
            }
            return field;
        }
        //public int[,] one(int[,] field)
        //{
        //    Random r = new Random();
        //    int x = 0, y = 0;
        //    bool iter = true;
        //    for (int i = 0; i < 4; i++)
        //    {
        //        do
        //        {
        //            x += r.Next(0, field.GetLength(0));
        //            y += r.Next(0, field.GetLength(1));
        //            if (field[x, y] == 0)
        //            {
        //            }
        //        } while (iter);
        //    }
        //    return field;
        //}
        public int[,] RandomField(int n)
        {
            if (n == 1)
            {
                getNullField();
                field[0, 0] = 3;
                field[0, 1] = 3;
                field[0, 2] = 3;

                field[9, 1] = 3;
                field[9, 2] = 3;
                field[9, 3] = 3;

                field[5, 1] = 4;
                field[5, 2] = 4;
                field[5, 3] = 4;
                field[5, 4] = 4;

                field[0, 5] = 2;
                field[0, 6] = 2;

                field[7, 3] = 2;
                field[7, 4] = 2;

                field[7, 8] = 2;
                field[7, 9] = 2;

                field[0, 9] = 1;
                field[2, 4] = 1;
                field[4, 8] = 1;
                field[9, 9] = 1;
                return field;
            }
            if (n==2)
            {
                getNullField();
                field[0, 3] = 3;
                field[0, 4] = 3;
                field[0, 5] = 3;

                field[0, 7] = 3;
                field[1, 7] = 3;
                field[2, 7] = 3;

                field[2, 9] = 4;
                field[3, 9] = 4;
                field[4, 9] = 4;
                field[5, 9] = 4;

                field[2, 0] = 2;
                field[3, 0] = 2;

                field[5, 0] = 2;
                field[5, 1] = 2;

                field[7, 0] = 2;
                field[7, 1] = 2;

                field[0, 0] = 1;
                field[0, 9] = 1;
                field[9, 0] = 1;
                field[9, 9] = 1;
                return field;
            }
            if (n==3)
            {
                getNullField();
                field[0, 4] = 3;
                field[1, 4] = 3;
                field[2, 4] = 3;

                field[4, 4] = 3;
                field[5, 4] = 3;
                field[6, 4] = 3;

                field[3, 6] = 4;
                field[4, 6] = 4;
                field[5, 6] = 4;
                field[6, 6] = 4;

                field[0, 2] = 2;
                field[1, 2] = 2;

                field[3, 2] = 2;
                field[4, 2] = 2;

                field[6, 2] = 2;
                field[7, 2] = 2;

                field[0, 0] = 1;
                field[2, 0] = 1;
                field[4, 0] = 1;
                field[6, 0] = 1;
                return field;
            }
            return null;
        }
        public void GetPrintMatrix(int n)
        {
            Random r = new Random();
            RandomField(r.Next(1,4));

            string len = new string('_', field.GetLength(1) * 8 + 1);

            Console.WriteLine("Ваша матрица:");

            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.WriteLine(len);

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"|{field[i, j]}\t");
                }
                Console.WriteLine("|");
            }
        }
    }
}
