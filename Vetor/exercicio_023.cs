/*23. Faça um programa que simule um lançamento de dados. Lance o dado 100 vezes e armazene os resultados em um vetor . Depois, mostre quantas vezes cada valor foi conseguido. Dica: use um vetor de contadores(1-6) e uma função para gerar numeros aleatórios, simulando os lançamentos dos dados.*/

using System;

class exercicio_023{
    
    static void Main(){

        int[] contador = new int[6];
        int numero = 0;

        Random random = new Random();

        for (int i = 0; i < 100; i++){

            numero = random.Next(1, 7);
            contador[numero - 1]++; 
        }

        for (int i = 0; i < 6; i++){

            Console.WriteLine("Numero " + (i + 1) + ": " + contador[i] + " vezes"); 
        }
    }
}