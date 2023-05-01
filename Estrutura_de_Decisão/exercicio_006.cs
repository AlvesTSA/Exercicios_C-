/* Faça um Programa que leia três números e mostre o maior deles.*/

using System;

class exercicio_006{
    
    static void Main(){
        
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int maior = 0;
        
        Console.WriteLine("Informe três núneros: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine()); 
        num3 = int.Parse(Console.ReadLine());
        
        if(num1 > num2 && num1 > num3){
            
            maior = num1;
            
        }
        
        else if(num2 > num3 && num2 > num1){
            
            maior = num2;
            
        }
        
        else{
            
            maior = num3;
              
        }
        
        Console.WriteLine("O número maior é: " + maior);
        
    }
}