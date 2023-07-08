/*Faça um programa que leia e valide as seguintes informações:

Nome: maior que 3 caracteres; 

Idade: entre 0 e 150; 

Salário: maior que zero;

Sexo: 'f' ou 'm';

Estado Civil: 's', 'c', 'v', 'd';
*/

using System;

class exercicio_003{

    static void Main(){

        string nome = " ";
        int idade = 0;
        float salario = 0;
        char sexo = ' ';
        char estado_civil = ' ';

        //Validação do nome

        do{
            
            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            if(nome.Length < 4){

                Console.WriteLine("Informe um nome válido maior que três caracteres.");
            }

        } while (nome.Length < 4); 

        //Validação da idade

        do{

            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade < 0 || idade > 150){

                Console.WriteLine("Informe uma idade válida");
            }

        }while(idade < 0 || idade > 150);

        //Validação do salário

        do{

            Console.WriteLine("Informe seu salário: ");
            salario = float.Parse(Console.ReadLine());

            if(salario <= 0){

                Console.WriteLine("Informe um salário válido");
            }

        }while(salario <= 0);

        //validação do sexo

        do{

            Console.WriteLine("Informe seu sexo: ");
            sexo = char.Parse(Console.ReadLine());

            if(sexo != 'm' && sexo != 'f'){

                Console.WriteLine("Informe um sexo válido");
            }

        }while(sexo != 'm' && sexo != 'f');

        //validação do estado civil

        do{

            Console.WriteLine("Informe seu estado civil: ");
            estado_civil = char.Parse(Console.ReadLine());

            if(estado_civil != 's' && estado_civil != 'c' && estado_civil != 'd' && estado_civil != 'v'){

                Console.WriteLine("Informe um valor válido");
            }

        }while(estado_civil != 's' && estado_civil != 'c' && estado_civil != 'd' && estado_civil != 'v');

        Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + "\nSalário: " + salario + "\nSexo: " + sexo + "\nEstado civil: " + estado_civil);

    }
}
