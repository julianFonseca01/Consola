/*
 * AUTOR: Julian Fonseca
 * DATE: jueves, 10 de noviembre de 2022 15:38
 * ABOUT: Ejercicios
 */


using Consola;

float valor = 23.30f;
double valor2 = 23.332334d;
decimal valor3 = 23.44234234234m;

Console.WriteLine(valor);
Console.WriteLine($"{valor2:N}");//valor dos decimales
Console.WriteLine($"{valor2:F}");//valor dos decimales
Console.WriteLine($"{valor3:C}"); //valor financiero

Calculadora calculadora = new Calculadora();
//calculadora.ShowDemo();
//calculadora.showNumberBig();
//calculadora.SeparaNumero5cifras();

Draw dibujar = new Draw();
//dibujar.DrawChess();
//dibujar.DrawCuadro();

//Estudiante julian = new Estudiante("Julian Fonseca", -59.01);


