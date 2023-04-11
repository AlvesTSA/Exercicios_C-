//Faça um Programa que peça dois números e imprima a soma.

using System;

class Exercicio_3{
    
    static void Main(){
        
        float num1, num2, soma;
        
        Console.WriteLine("Informe o primeiro número: ");
        num1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe o segundo número: ");
        num2 = float.Parse(Console.ReadLine());
        
        soma = num1 + num2;
        
        Console.WriteLine("A soma dos números é: " + soma);
        
    }
}