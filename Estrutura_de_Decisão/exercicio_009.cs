/* Faça um Programa que leia três números e mostre-os em ordem decrescente.*/

using System;

class exercicio_009{
    
    static void Main(){
        
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int maior1 = 0;
        int maior2 = 0;
        int maior3 = 0;
        
        Console.WriteLine("Informe três números: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());
        
        if(num1 > num2 && num1 > num3){
            
            maior1 = num1;
            
            if(num2 > num3){
                
                maior2 = num2;
                maior3 = num3;
                
            }
            else{
                
                maior2 = num3;
                maior3 = num2;
                
            }
            
        }
        
        else if(num2 > num1 && num2 > num3){
            
            maior1 = num2;
            
            if(num1 > num3){
                
                maior2 = num1;
                maior3 = num3;
                
            }
            else{
                
                maior2 = num3;
                maior3 = num1;
                
            }
            
        }
        
        else{
            
            maior1 = num3;
            
            if(num1 > num2){
                
                maior2 = num1;
                maior3 = num2;
                
            }
            else{
                
                maior2 = num2;
                maior3 = num1;
                
            }
            
        }
        
        Console.WriteLine("Ordem decrescente: \n" + "1° " + maior1 + "\n2° " + maior2 + "\n3° " + maior3);
        
    }
}