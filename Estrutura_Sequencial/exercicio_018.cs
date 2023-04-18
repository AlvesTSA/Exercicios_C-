/*Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link de Internet (em Mbps), calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).*/

using System;

class Exercicio_18{

    static void Main(){

        int mb = 0;
        int mbps = 0;
        int t = 0;

        Console.Write("Informe o tamanho do arquivo: ");
        mb = int.Parse(Console.ReadLine());

        Console.Write("Informe a velocidade do link: ");
        mbps = int.Parse(Console.ReadLine());

        t = mb/mbps;

        Console.WriteLine("Tempo de dowloading: " + t + "min");

    }
}