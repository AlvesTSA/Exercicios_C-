/*3. Faça um Programa que leia 4 notas, mostre as notas e a média na tela.*/

using System;

class exercicio_003{

    static void Main(){

        float[] notas = new float[4];
        float media  = 0;

        Console.WriteLine("Informe suas 4 notas:");

        for (int i = 0; i < 4; i++){
            
            notas[i] = float.Parse(Console.ReadLine());

            media += notas[i]; 
        }

        media = media / 4;
        Console.Write("Notas: ");

        for (int i = 0; i < 4; i++){
            
            Console.Write(notas[i] + " ");
        }

        Console.WriteLine("\nMedia: " + media);
    }
}