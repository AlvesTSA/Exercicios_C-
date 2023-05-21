/*Faça um Programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar. O resultado da operação deve ser acompanhado de uma frase que diga se o número é par ou ímpar e positivo ou negativo*/

using System;

class exercicio_020{

    static void Main(){

        int num1 = 0;
        int num2 = 0;
        int resultado = 0;
        int op = 0;

        Console.WriteLine("Informe dois números: ");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escolha a operação\n\n[1]Adição\n[2]Subtração\n[3]Multiplicação\n[4]Divisão\n");
        op = int.Parse(Console.ReadLine());

        switch (op){
        case 1:

            resultado = num1 + num2;

            break;
        
        case 2:
        
            resultado = num1 - num2;

            break;
        
        case 3:

            resultado = num1*num2;
        
            break;
        
        case 4:

            if(num2 == 0){

                Console.WriteLine("Não existe divisão por zero.");
            
                Environment.Exit(0);

            }
            else{

                resultado = num1/num2;

            }

            break;
        
        default:

            Console.WriteLine("Informe uma opção válida.");

            Environment.Exit(0);

            break;
        }

        if(resultado % 2 == 0){

            if(resultado > 0){

                Console.WriteLine("Resultado: " + resultado + "  é par e positivo."); 

            }
            else if(resultado == 0){

                Console.WriteLine("Resultado: " + resultado + "  é par e neutro.");

            }
            else{

                Console.WriteLine("Resultado: " + resultado + "  é par e negativo.");
            }
        }
        else{

            if(resultado < 0){

                Console.WriteLine("Resultado: " + resultado + "  é impar e negativo.");
            }
            else{

                Console.WriteLine("Resultado: " + resultado + "  é impar e positivo.");
            }
        }
    }
}