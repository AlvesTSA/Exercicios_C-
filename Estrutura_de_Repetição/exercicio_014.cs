/*14. Faça um programa que peça 10 números inteiros, calcule e mostre a quantidade de números pares e a quantidade de números impares.*/

using System;

class exercicio_014{

    static void Main(){

        int num = 0;
        int par = 0;
        int impar = 0;
        int resto = 0;

        Console.WriteLine("Informe 10 numerows inteiros:");

        for (int i = 0; i < 10; i++){
            
            num = int.Parse(Console.ReadLine());
            resto = num % 2;

            if (resto == 0){
                
                par++;
            }
            else{

                impar++;
            }
        }

        Console.WriteLine("Quantidade de impar: " + impar + "\nQuantidade de par: " + par);

    }
}