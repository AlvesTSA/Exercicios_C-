/*5. Faça um Programa que leia 20 números inteiros e armazene-os num vetor. Armazene os números pares no vetor PAR e os números IMPARES no vetor impar. Imprima os três vetores.*/

using System;

class exercicio_004{

    static void Main(){

        int[] numeros = new int[20];
        float resto = 0;
        int count_par = 0;
        int count_impar = 0;

        Console.WriteLine("Informe 20 numeros inteiros:");

        for (int i = 0; i < 20; i++){
            
            numeros[i] = int.Parse(Console.ReadLine());
            resto = numeros[i] % 2;

            if (resto == 0){
                
                count_par++;
            }
            else{
                
                count_impar++;
            }
        }

        int[] par = new int[count_par];
        int[] impar = new int[count_impar];
        int y = 0;
        int z = 0;

        for (int i = 0; i < 20; i++){
            
            resto = numeros[i] % 2;

            if (resto == 0){
                
                par[y] = numeros[i];
                y++;
            }
            else{
                
                impar[z] = numeros[i];
                z++;
            }
        }

        Console.Write("Numeros lidos: ");

        for (int i = 0; i < 20; i++){
            
            Console.Write(numeros[i] + " ");
        }

        Console.Write("\n\nNumeros pares: ");

        if (count_par == 0){
                
            Console.Write("Nenhum numero par identificado.");
        }

        for (int i = 0; i < count_par; i++){
            
            Console.Write(par[i] + " ");
        }

        Console.Write("\n\nNumeros impares: ");

        if (count_impar == 0){
                        
            Console.Write("Nenhum numero impar identificado.");
        }

        for (int i = 0; i < count_impar; i++){

            Console.Write(impar[i] + " ");
        }
    }
}