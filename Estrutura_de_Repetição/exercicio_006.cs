/*Faça um programa que imprima na tela os números de 1 a 20, um abaixo do outro. Depois modifique o programa para que ele mostre os números um ao lado do outro.*/

using System;

class exercicio_006{

    static void Main(){

        int i = 0;

        for (i = 1; i <= 20; i++){
            
            Console.WriteLine(i + "\n");
        }
        for (i = 1; i <= 20; i++){
            
            Console.Write(i + " ");
        }
    }
}