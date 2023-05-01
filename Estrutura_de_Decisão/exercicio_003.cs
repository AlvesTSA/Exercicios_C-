/*. Faça um Programa que verifique se uma letra digitada é "F" ou "M". Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.*/

using System;

class exercicio_003{
    
    static void Main(){
        
        string letra;
        
        Console.WriteLine("Informe F ou M: ");
        letra = Console.ReadLine();
        
        if(letra == "M" || letra == "m"){
            
            Console.WriteLine("MASCULINO");
            
        }
        else if(letra == "F" || letra == "f"){
            
            Console.WriteLine("FEMININO");
            
        }
        else{
            
            Console.WriteLine("Sexo Inválido");
            
        }
        
    }
}