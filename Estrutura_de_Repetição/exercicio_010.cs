/* Faça um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo compreendido por eles.*/

using System;

class exercicio_010{

    static void Main(){

        int num1 = 0, num2 = 0, num = 0;
        int temp = 0;

        Console.Write("Informe o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        if(num1 > num2){

            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.Write("Valores no intervalo entre " + num1 + " e " + num2 + " são: ");

        while (num1 < num2 - 1){
            
            num1 ++;

            Console.Write(num1 + " ");
           
        }
    }
}