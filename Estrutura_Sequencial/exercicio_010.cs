//Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Fahrenheit.F = 1.8*C + 32

using System;

class Exercicio_10{
    
    static void Main(){
        
        double F, C;
        
        Console.WriteLine("Informe a temperatura em Celsius: ");
        C = double.Parse(Console.ReadLine());
        
        F = (1.8*C) + 32;
        
        Console.WriteLine("A temperatura em Fahrenheit é: "+F+"°");
        
    }
}