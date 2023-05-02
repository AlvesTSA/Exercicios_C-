/*Faça um Programa que pergunte em que turno você estuda.
Peça para digitar M-matutino ou V-Vespertino ou N- Noturno. 
Imprima a mensagem "Bom Dia!", "Boa Tarde!" ou "Boa Noite!" ou "Valor Inválido!", conforme o caso.*/

using System;

class exercicio_010{
    
    static void Main(){
        
        char turno;
        
        Console.WriteLine("Qual turno você estuda?\nDigite a letra correspondente:\nM-matutino\nV-Vespertino\nN-Noturno");
        turno = char.Parse(Console.ReadLine());
        
        switch(turno){
            
            case 'M':   
                Console.WriteLine("BOM DIA !");
                break;
        
            case 'V':   
                Console.WriteLine("BOA TARDE !");
                break;
        
            case 'N':   
                Console.WriteLine("BOA NOITE !");
                break;
            
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}
