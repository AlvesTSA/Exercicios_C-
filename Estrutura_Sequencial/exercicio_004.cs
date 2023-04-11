//Faça um Programa que peça as 4 notas bimestrais e mostre a média.

using System;

class Exercicio_4{
    
    static void Main(){
        
        float nota1, nota2, nota3, nota4, media;
        
        Console.WriteLine("Informe a nota do primeiro bimestre: ");
        nota1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a nota do segundo bimestre: ");
        nota2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a nota do terceiro bimestre: ");
        nota3 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a nota do quarto bimestre: ");
        nota4 = float.Parse(Console.ReadLine());
        
        media = (nota1 + nota2 +nota3 + nota4)/4;
        
        Console.WriteLine("Sua nota final é: " + media);
        
    }
}