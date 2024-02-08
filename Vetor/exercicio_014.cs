/*14. Utilizando listas faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

"Telefonou para a vítima?" 

"Esteve no local do crime?" 

"Mora perto da vítima?"

"Devia para a vítima?"

"Já trabalhou com a vítima?"

O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ele será classificado como "Inocente".*/

using System;

class exercicio_014{

    static void Main(){

        char[] resposta = new char[5];
        int count = 0;

        for (int i = 0; i < 5; i++){
            
            switch (i + 1){
                case 1:
                    Console.WriteLine("Telefonou para a vítima? : ");
                    resposta[i] = char.Parse(Console.ReadLine());
                break;
                case 2:
                    Console.WriteLine("Esteve no local do crime?" :);
                    resposta[i] = char.Parse(Console.ReadLine());
                break;
                case 3:
                    Console.WriteLine("Mora perto da vítima? : ");
                    resposta[i] = char.Parse(Console.ReadLine());
                break;
                case 4:
                    Console.WriteLine("Devia para a vítima? : ");
                    resposta[i] = char.Parse(Console.ReadLine());
                break;
                case 5:
                    Console.WriteLine("Já trabalhou com a vítima? : ");
                    resposta[i] = char.Parse(Console.ReadLine());
                break;
                default:
                    Console.WriteLine("VAlor invalido");
                    break;
            }   
        }
    }
}