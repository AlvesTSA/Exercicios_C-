/* Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.*/

using System;

class exercicio_002{

    static void Main(){

        int valor = 0;

        Console.WriteLine("Informe um valor: ");
        valor = int.Parse(Console.ReadLine());

        if (valor > 0){

            Console.WriteLine("Valor positivo");
            
        }
        else{

            Console.WriteLine("Valor negativo");

        }
    }
}