/*Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72.7*altura) - 58
*/

using System;

class Exercicio_12{
    static void Main(){

    double altura = 0;
    double peso = 0;

    Console.WriteLine("Informe a sua altura: ");
    altura = double.Parse(Console.ReadLine());

    peso = (72.7*altura) - 58;

    Console.WriteLine("Peso ideal: " + peso);

    }
}
