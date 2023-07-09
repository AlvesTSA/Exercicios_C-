/*Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de crescimento de 3% e que a população de B seja 200000 habitantes com uma taxa de crescimento de 1.5%. Faça um programa que calcule e escreva o número de anos necessários para que a população do país A ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento. */

using System;

class exercicio_004{

    static void Main(){

        double habitante_A = 80000;
        double habitante_B = 200000;
        double taxa_A = 0.03;
        double taxa_B = 0.015;
        int ano = 0;

        while(habitante_A < habitante_B){

            habitante_A = habitante_A*Math.Pow(1 + taxa_A, ano++);
            habitante_B = habitante_B*Math.Pow(1 + taxa_B, ano++);
        }

        Console.WriteLine("Anos necessários: " + ano);

    }
}