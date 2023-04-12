//Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.

using System;

class Exercicio_6{
    
    static void Main(){
        
        double raio, area;
        
        Console.WriteLine("Informe o raio: ");
        raio = double.Parse(Console.ReadLine());
        
        area = 3.14*(raio*raio);
        
        Console.WriteLine("A área do círculo é: "+ area);
        
    }
}