/*. Faça um Programa que leia um número e exiba o dia correspondente da semana. (1- Domingo , 2- Segunda, etc). Se digitar outro valor, deve aparecer “valor inválido.*/

using System;

class exercicio_013{

    static void Main(){

        int dia = 0;

        Console.WriteLine("Informe um valor de 1 a 7: ");
        dia = int.Parse(Console.ReadLine());

        switch (dia){

        case 2:
            Console.WriteLine("SEGUNDA");

            break;
        
        case 3:
            Console.WriteLine("TERÇA FEIRA");
            
            break;
        
        case 4:
            Console.WriteLine("QUARTA FEIRA");
            
            break;
        
        case 5:
            Console.WriteLine("QUINTA FEIRA");
            
            break;

        case 6:
            Console.WriteLine("SEXTA FEIRA");
            
            break;

        case 7:
            Console.WriteLine("SABADO");
            
            break;
        
        case 1:
            Console.WriteLine("DOMINGO");
            
            break;
        
        default:
            Console.WriteLine("VALOR INVÁLIDO");

            break;
        }
    }
}

