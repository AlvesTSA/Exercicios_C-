/*
Faça um Programa que leia um número inteiro menor que 1000 e imprima a quantidade de centenas, dezenas e unidades do mesmo.Exemplo:326 = 3 centenas, 2 dezenas e 6 unidades
*/

using System;

class exercicio_021{

    static void Main(){

        int centena = 0;
        int dezena = 0;
        int unidade = 0;
        int num = 0;

        Console.WriteLine("Informe uma número inteiro ate 1000: ");
        num = int.Parse(Console.ReadLine());

        if(num > 0 && num < 1000){

            centena = num / 100;
            num %= 100;
            dezena = num / 10;
            num %= 10;
            unidade = num;

        }
        else{

            Console.WriteLine("Informe um número válido");

            Environment.Exit(0);

        }

        Console.WriteLine("Centena: " + centena + "\nDezena: " + dezena + "\nUnidade: " + unidade);

        Environment.Exit(0);
    }
}