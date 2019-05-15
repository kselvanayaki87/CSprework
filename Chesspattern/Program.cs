using System;

namespace Chesspattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //print 8*8 pattern chess board
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                    if (j % 2 == i % 2)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                Console.WriteLine();

            }
        }
    }
}
