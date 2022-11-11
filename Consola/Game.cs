// Destinado a algoritmos de juegos 

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    internal class Game
    {
        public bool a = false;
        
    }
}

//// Funciones.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
////

//#include <iostream>
//#include <cmath>
//#include <cstdlib>
//#include <iomanip>
//#include <ctime>

//#define END std::cout<<"\n"; for (size_t i = 0; i < 100; i++) {std::cout << "-"; }std::cout<<"\n"; //MACRO para linea de termino de programa
//#define LINE std::cout<<"\n"; for (size_t i = 0; i < 50; i++) {std::cout << "-"; }std::cout<<"\n"; //MACRO para linea de termino de programa

//void simulacionTiroDado(int);
//int simulacionCraps();
//void porValor(int);
//void porReferencia(int&);

//int main()
//{


//    LINE;

//    std::cout << "PASO x VALOR y Referencia" << std::endl;
//    int a = 2;
//    int b = 2;

//    porValor(a);
//    std::cout << "Por valor es:" << a << std::endl;

//    porReferencia(b);
//    std::cout << "Por referencia es:" << b << std::endl;





//    LINE;

//    /*char opt;
//	int contador;
//	int contadorWin = 0;
//	int contadorLost = 0;

//	while (true)
//	{
//		std::cout << "\nJUGAR ?(s to Play,n to Exit): ";
//		std::cin >> opt;
//		if (opt == 'n')
//		{
//			break;
//		}
//		else if (opt == 's') {
//			contador = simulacionCraps();
//			if (contador == 1) contadorWin++;
//			if (contador == 0) contadorLost++;

//			std::cout << "\nJUEGO TERMINADO" << std::endl;
//			std::cout << "\nVeces Win: " << contadorWin << std::endl;
//			std::cout << "\nVeces Lost: " << contadorLost << std::endl;
//		}
//		else std::cout << "opcion incorrecta" << std::endl;
//	}*/


//    LINE;

//    //std::cout << "Hello FUNCIONES!\n";
//    //std::cout << "RAIZ cuadra de 900: " << std::sqrt(900);

//    LINE;

//    //int tiros = 0;

//    //while (true) {
//    //	std::cout << "\nIngrese el numero de tiros(-1 to exit): ";
//    //	std::cin >> tiros;

//    //	if (tiros == -1)
//    //	{
//    //		break;
//    //	}

//    //	simulacionTiroDado(tiros);

//    //}





//    END;

//}

//void porValor(int valor)
//{
//    std::cout << "El valor ingresado es " << valor << std::endl;
//    std::cout << "El valor Modificado es " << valor + 1000 << std::endl;
//    valor = valor + 1000;
//}

//void porReferencia(int& valor)
//{
//    std::cout << "El valor ingresado por referencia es " << valor << std::endl;
//    std::cout << "El valor Modificado es " << valor + 1001 << std::endl;
//    valor = valor + 1001;
//}

//void simulacionTiroDado(int tiros)
//{

//    int contador1 = 0, contador2 = 0, contador3 = 0, contador4 = 0, contador5 = 0, contador6 = 0;
//    int randomNumber;

//    srand(time(0)); //para que tome numeros aleatorios a partir de una semilla. La semilla es el numero de segundos actual con time(0)

//    for (size_t i = 1; i <= tiros; i++)
//    {
//        randomNumber = 1 + (std::rand() % 6);
//        std::cout << std::setw(5) << randomNumber;

//        if (randomNumber == 1) contador1++;
//        if (randomNumber == 2) contador2++;
//        if (randomNumber == 3) contador3++;
//        if (randomNumber == 4) contador4++;
//        if (randomNumber == 5) contador5++;
//        if (randomNumber == 6) contador6++;

//        if (i % 5 == 0) { std::cout << "\n"; }

//    }

//    std::cout << "\nINFORME" << std::endl;
//    std::cout << "\nnumero de veces 1: " << contador1 << std::endl;
//    std::cout << "\nnumero de veces 2: " << contador2 << std::endl;
//    std::cout << "\nnumero de veces 3: " << contador3 << std::endl;
//    std::cout << "\nnumero de veces 4: " << contador4 << std::endl;
//    std::cout << "\nnumero de veces 5: " << contador5 << std::endl;
//    std::cout << "\nnumero de veces 6: " << contador6 << std::endl;




//}

//int simulacionCraps()
//{
//    /*
//	* Un jugador lanza dos dados. Cada dado tiene seis caras. Estas caras comienen 1, 2, 3, 4. 5 y 6 puntos.
//Una vez que los dados caen, se calcula la suma de los puntos de las caras superiores de ambos dados.
//Si la suma es 7 u 11 en el primer tiro, el jugador gana. Si la suma es 2, 3 o 12 en el primer tiro
//(llamado “craps “), el jugador pierde (es decir, la “casa" gana) - Si la suma es 4, 5, 6, 8, 9 o 10 en el
//primer tiro, entonces ésta se convierte en “punto” del jugador. Para ganar, usted debe continuar tirando
//los dados hasta que “haga su punto”. El jugador pierde si tira 7 veces sin sacar el punto.
//	*/

//    LINE;
//    srand(time(0));

//    int dado1 = 1 + (std::rand() % 6);
//    int dado2 = 1 + (std::rand() % 6);

//    int punto;
//    int contador = 0;

//    int suma = dado1 + dado2;


//    if (suma == 7 || suma == 11)
//    {
//        std::cout << "\nJugador GANA!!!! con: " << suma << std::endl;
//        return 1;
//    }
//    else if (suma == 2 || suma == 3 || suma == 12)
//    {
//        std::cout << "\nJugador PIERDE con: " << suma << std::endl;
//        return 0;
//    }
//    else
//    {
//        std::cout << "\nJugador continua con: " << suma << std::endl;

//        punto = suma;
//        for (size_t i = 0; i < 7; i++)
//        {
//            dado1 = 1 + (std::rand() % 6);
//            dado2 = 1 + (std::rand() % 6);
//            suma = dado1 + dado2;

//            std::cout << "\nJugador sigue en juego con: " << suma << std::endl;

//            contador++;

//            if (suma == punto)
//            {
//                std::cout << "\nJugador GANA en el " << contador << " intento" << std::endl;
//                return 1;
//                break;
//            }

//        }

//        if (suma != punto)
//        {
//            std::cout << "\nJugador PIERDE en el " << contador << " intento" << std::endl;
//            return 0;

//        }
//    }
//    LINE;

//}

