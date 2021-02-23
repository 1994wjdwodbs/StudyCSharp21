using System;


namespace StarTestApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("별모양 찍기");
            
            #region 첫번째별모양
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            #endregion

            #region 두번째별모양
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            #endregion

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j == i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
