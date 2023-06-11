/*Para doar sangue é necessário ter entre 18 e 67 anos. Faça um aplicativo que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não. Use alguns dos operadores lógicos OU (||) e E (&&).*/

using System;

class exercicio_025{

    static void Main(){

        int idade = 0;

        Console.WriteLine("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if(idade >= 18 && idade <= 67){

            Console.WriteLine("Doador autorizado");
        }
        else{

            Console.WriteLine("Não autorizado");
        }
    }
}