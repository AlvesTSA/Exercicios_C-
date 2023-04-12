//Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.

using System;

class Exercicio_7{
    
    static void Main(){
        
        float area, lado;
        
        Console.WriteLine("Informe a medida de um dos lados do quadrado: ");
        lado = float.Parse(Console.ReadLine());
        
        area = (lado*lado)*2;
        
        Console.WriteLine("O dobro da área é: "+ area);
        
    }
}