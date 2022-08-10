using System;

namespace Exercise_8
{
    public class AsciiFigure
    {
        public void DrawFigure(int size)
        {
            char a = '*';
            char fs = '/';
            char bs = '\\';

            for (int i = 1; i <= size; i++)
            {
                string line = "";

                for (int j = 0; j < (size - i) * 4; j++)
                {
                    line += fs;
                }

                for (int k = 0; k < (i - 1) * 8; k++)
                {
                    line += a;
                }

                for (int l = 0; l < (size - i) * 4; l++)
                {
                    line += bs;
                }

                Console.WriteLine(line);
            }

        }
    }
}