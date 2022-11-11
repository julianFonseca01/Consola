using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Calculadora
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0) a = value;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0) b = value;
            }
        }

        public Calculadora() { }

        public void ShowDemo()
        {
            Console.Write("Ingrese numero 1: ");
            Console.ForegroundColor = ConsoleColor.Green;
            A = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ingrese numero 2: ");
            Console.ForegroundColor = ConsoleColor.Green;
            B = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine($"La suma es: {this.Suma():N}");
            Console.WriteLine($"La resta es: {this.Resta():N}");
            Console.WriteLine($"La multiplicacion es: {this.Multiplica():N}");
            Console.WriteLine($"La division es: {this.Divide():N}");
            Console.WriteLine($"El residuo es: {this.Residuo():N}"); // Solo para numeros enteros
        }   

        public void SeparaNumero5cifras()
        {
            int a1, a, b1, b, c1, c, d1, e1, numero;

            Console.Write("Ingrese numero 5 cifras: ");
            numero = int.Parse(Console.ReadLine());

            a1 = numero / 10000;
            a = numero % 10000;

            b1 = a / 1000;
            b = a % 1000;

            c1 = b / 100;
            c = b % 100;

            d1 = c / 10;
            e1 = c % 10;

            Console.WriteLine($"NUMERO: {a1} {b1} {c1} {d1} {e1}");
        }

        private double Suma()
        {
            return A + B;
        }

        private double Resta()
        {
            return A - B;
        }

        private double Multiplica()
        {
            return A * B;
        }

        private double Divide()
        {
            return A / B;
        }

        private double Residuo()
        {
            return A % B;
        }

        public void showNumberBig()
        {
            // usuario ingresa 5 numeros y despliega el mayor

            double[] numero = new double[6];
            double numeroMayor = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese numero {i}: ");
                numero[i] = double.Parse(Console.ReadLine());
                if (numero[i]>numeroMayor)
                {
                    numeroMayor = numero[i];
                }
            }

            Console.WriteLine($"El numero mayor es: {numeroMayor}");

        }

    }
}
