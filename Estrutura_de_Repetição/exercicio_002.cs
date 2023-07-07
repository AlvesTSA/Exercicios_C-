/*Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.*/

using System;

class exercicio_002{

    static void Main(){

        string nome = "";
        string senha = "";

        do{

          Console.WriteLine("Informe o nome de usuário");
          nome = Console.ReadLine();
          Console.WriteLine("Informe a senha");
          senha = Console.ReadLine();

          if(nome == senha){

            Console.WriteLine("ERROR: a senha não pode ser igual ao nome de usuário");
            
          }  
        } while (nome == senha);

        Console.WriteLine("Nome e senha criado com sucesso");
    }
}