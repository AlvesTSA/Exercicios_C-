/*25. Faça um programa que peça para n pessoas a sua idade, ao final o programa devera verificar se a média de idade da turma varia entre 0 e 25,26 e 60 e maior que 60; e então, dizer se a turma é jovem, adulta ou idosa, conforme a média calculada.

*/

using System;

public class exercicio_025{

    static void Main(){

        int idade = 0;
        int soma = 0;
        int media = 0;
        int n = 0;

        Console.WriteLine("Informe quantas pessoas deseja informar a idade: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe as idades: ");

        for (int i = 0; i < n; i++){

            idade = int.Parse(Console.ReadLine());

            soma += idade;
        }
        media = soma/n;

        if (media > 0 && media <= 25){
            
            Console.WriteLine("Turma jovem");
        }
        else if(media >= 26 && media <= 60){

            Console.WriteLine("Turma adulta");
        }
        else{

            Console.WriteLine("Turma idosa");
        }
    }
}