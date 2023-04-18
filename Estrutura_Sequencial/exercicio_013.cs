/*Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7*h) - 58
Para mulheres: (62.1*h) - 44.7
*/

using System;

class Exercicio_13{

    static void Main(){

        double h = 0;
        double peso_homem = 0;
        double peso_mulher = 0;

        Console.WriteLine("Informe a sua altura: ");
        h = double.Parse(Console.ReadLine());

        peso_homem = (72.7*h) - 58;
        peso_mulher = (62.1*h) - 44.7;

        Console.WriteLine("Peso ideal para homens: " + peso_homem);
        Console.WriteLine("Peso ideal para mulheres: " + peso_mulher);
        
    }
}