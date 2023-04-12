//Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a temperatura em graus Celsius.C = 5 * ((F-32) / 9).

using System;

class Exercicio_9{
    
    static void Main(){
        
        float fahrenheit, celsius;
        
        Console.WriteLine("informe a temperatura em fahrenheit: ");
        fahrenheit = float.Parse(Console.ReadLine());
        
        celsius = 5 * ((fahrenheit-32) / 9);
        
        Console.WriteLine("A tenperatura em celsius é: "+ celsius+"°");
        
        
    }
}