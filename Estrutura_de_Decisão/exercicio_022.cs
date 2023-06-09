/* Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
“Telefonou para a vítima? “ 

“Esteve no local do crime?” 

“Mora perto da vítima? “

“Devia para a vítima? “

“Já trabalhou com a vítima? “

O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como “Suspeita”, entre 3 e 4 como “Cúmplice” e 5 como “Assassino“. Caso contrário, ele será classificado como “Inocente“.*/

using System;

class exercicio_022{

    static void Main(){

        char resposta1;
        char resposta2;
        char resposta3;
        char resposta4;
        char resposta5;
        int contador = 0;

        Console.WriteLine("Responda com 's para sim e 'n para não");
        Console.WriteLine("Telefonou para a vítima?");
        resposta1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Esteve no local do crime?");
        resposta2 = char.Parse(Console.ReadLine());
        Console.WriteLine("Mora perto da vítima?");
        resposta3 = char.Parse(Console.ReadLine());
        Console.WriteLine("Devia para a vítima?");
        resposta4 = char.Parse(Console.ReadLine());
        Console.WriteLine("Já trabalhou com a vítima?");
        resposta5 = char.Parse(Console.ReadLine());

        if(resposta1 == 's'){

            contador ++;

        }
        if(resposta2 == 's'){

            contador ++;
            
        }
        if(resposta3 == 's'){

            contador ++;
            
        }
        if(resposta4 == 's'){

            contador ++;
            
        }
        if(resposta5 == 's'){

            contador ++;
            
        }
        if(contador == 2){

            Console.WriteLine("Suspeito");

        }
        else if(contador >= 3 && contador <=4){

            Console.WriteLine("Cumplice");
        }
        else if(contador == 5){
            
            Console.WriteLine("Assassino");

        }
        else{

            Console.WriteLine("Inocente");

        }

    }
}