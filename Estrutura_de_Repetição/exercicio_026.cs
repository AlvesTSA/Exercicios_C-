/*26. Numa eleição existem três candidatos. Faça um programa que peça o número total de eleitores. Peça para cada eleitor votar e ao final mostrar o número de votos de cada candidato.*/

using System;

public class exercicio_026{

    static void Main(){

        int eleitor = 0;
        int candidato = 0;
        int candidato1 = 0;
        int candidato2 = 0;
        int candidato3 = 0;

        Console.WriteLine("Infome a quantidade de eleitores: ");
        eleitor = int.Parse(Console.ReadLine());

        for (int i = 0; i < eleitor; i++){
            
            Console.WriteLine("Vote [1] [2] [3]");
            candidato = int.Parse(Console.ReadLine());

            switch (candidato){

                case 1:

                    candidato1++;
                    break;
                case 2:

                    candidato2++;
                    break;
                case 3:
                    
                    candidato3++;
                    break;
                default:

                    Console.WriteLine("Erro: vote 1, 2 ou 3");
                    break;
            }
        }

        Console.WriteLine("Candidato 1: " + candidato1 + " votos");
        Console.WriteLine("Candidato 2: " + candidato2 + " votos");
        Console.WriteLine("Candidato 3: " + candidato3 + " votos");

        
    }
}