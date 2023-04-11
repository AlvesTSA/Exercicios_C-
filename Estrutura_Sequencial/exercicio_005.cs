//Faça um Programa que converta metros para centímetros.

using System;

class Exercicio_5{
    
    
    static void Main(){
        
        float m, cm;
        
        Console.WriteLine("Informe uma medida em metros: ");
        m = float.Parse(Console.ReadLine());
        
        cm = m*100;
        
        Console.WriteLine("A medida em centímetro é: " + cm + "cm");
        
    }
}