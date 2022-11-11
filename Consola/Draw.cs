using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Draw
    {
        public Draw() { }

        public void DrawChess()
        {
            int tamanox, tamanoy;

            Console.Write("Ingrese tamano: ");
            tamanox = int.Parse(Console.ReadLine());
            tamanoy = tamanox / 2;

            for (int i = 0; i < tamanoy; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < tamanox; j++)
                {
                    if ((i % 2) == 0)
                    {
                        if ((j % 2) == 0) Console.Write("*");
                        else Console.Write(" ");
                    }
                    if ((i % 2) != 0)
                    {
                        if ((j % 2) == 0) Console.Write(" ");
                        else Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
        }

        public void DrawCuadro()
        {
            int tamano;

            Console.Write("Ingrse tamano: ");
            tamano = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamano; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < tamano; j++)
                {
                    if (i == 0) Console.Write("*");
                    else if (i == (tamano - 1)) Console.Write("*");
                    else if (j == 0 || j == (tamano - 1)) Console.Write("*");
                    else Console.Write(" ");
                }
            }
        }

    }
}
