/*Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.*/

using System;

class exercicio_001{

        static void Main(){

            int nota = 0;

            do{
                Console.WriteLine("Informe uma nota de entre 0 e 10:");
                nota = int.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10){

                    Console.WriteLine("Valor inválido");
                } 

            } while (nota < 0 || nota > 10);

            Console.WriteLine("Nota: " + nota);
        }

}