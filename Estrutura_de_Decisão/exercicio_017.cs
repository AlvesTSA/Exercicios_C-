/*. Faça um Programa que peça um número correspondente a um determinado ano e em seguida informe se este ano é ou não bissexto.*/

using System;

class exercicio_017{

    static void Main(){

        int ano = 0;

        Console.WriteLine("Informe um ano: ");
        ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)){

            Console.WriteLine(ano + "é um ano bissexto.");

        }
        else{

            Console.WriteLine(ano + "não é um ano bissexto.");

        }
    }
}