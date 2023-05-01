/* Faça um programa para a leitura de duas notas parciais de um aluno. O programa deve calcular a média alcançada por aluno e apresentar:

A mensagem "Aprovado", se a média alcançada for maior ou igual a sete; 

A mensagem "Reprovado", se a média for menor do que sete; 

A mensagem "Aprovado com Distinção", se a média for igual a dez.
*/

using System;

class exercicio_005{
    
    static void Main(){
        
        float num1 = 0;
        float num2 = 0;
        float media = 0;
        
        Console.WriteLine("Informe duas notas: ");
        num1 = float.Parse(Console.ReadLine());
        num2 = float.Parse(Console.ReadLine());
        
        media = (num1 + num2)/2;
        
        if(media >= 7 && media < 10){
            
            Console.WriteLine("Aprovado");
            
        }
        else if(media > 0 && media < 7){
            
            Console.WriteLine("Reprovado");
            
        }
        else if(media == 10){
            
            Console.WriteLine("Aprovado com distinção");
            
        }
    }
    
}