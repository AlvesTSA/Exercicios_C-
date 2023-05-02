/* Faça um Programa que leia três números e mostre o maior e o menor deles.*/

using System;

class exercicio_007{
    
    static void Main(){
        
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int maior = 0;
        int menor = 0;
        
        Console.WriteLine("Informe três números: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        
        if(num1 > num2 && num1 > num3){
            
            maior = num1;
            
            if(num2 < num3){
                
                menor = num2;
            
            }
            else{
                
                menor = num3;
                
            }
        }
        
        else if(num2 > num1 && num2 > num3){
            
            maior = num2;
            
            if(num1 < num3){
                
                menor = num1;
            
            }
            else{
                
                menor = num3;
                
            }
        }
        
        else{
            
            maior = num3;
            
            if(num2 < num1){
                
                menor = num2;
            
            }
            else{
                
                menor = num1;
                
            }
        }
        
        Console.WriteLine("Maior: " + maior + "\nMenor: " + menor);
    }
}