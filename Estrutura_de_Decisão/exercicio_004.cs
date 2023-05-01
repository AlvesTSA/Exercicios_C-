/*. Faça um Programa que verifique se uma letra digitada é vogal ou consoante.*/

using System;

class exercicio_004{

    static void Main(){

        string letra;

        Console.WriteLine("Informe uma letra: ");
        letra = Console.ReadLine();

        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U"){

            Console.WriteLine("VOGAL");
   
        }
        else{

            Console.WriteLine("CONSOANTE");
            
        }
    }
}