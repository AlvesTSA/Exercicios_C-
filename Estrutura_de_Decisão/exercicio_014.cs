/* Faça um programa que lê as duas notas parciais obtidas por um aluno numa disciplina ao longo de um semestre, e calcule a sua média. A atribuição de conceitos obedece à tabela abaixo:
 
Média de aproveitamento: entre 9.0 e 10.0; Conceito: A 
 
Média de aproveitamento: entre 7.5 e 9.0; Conceito: B 

Média de aproveitamento: entre 6.0 e 7.5; Conceito: C 
 
Média de aproveitamento: entre 4.0 e 6.0; Conceito: D  

Média de aproveitamento: entre 4.0 e 0.0; Conceito: E 

O algoritmo deve mostrar na tela as notas, a média, o conceito correspondente e a mensagem “APROVADO” se o conceito for A, B ou C ou “REPROVADO” se o conceito for D ou E.
*/

using System;

class exercicio_014{

    static void Main(){

        float nota1 = 0;
        float nota2 = 0;
        float media = 0;

        Console.WriteLine("Informe suas duas notas: ");
        nota1 = float.Parse(Console.ReadLine());
        nota2 = float.Parse(Console.ReadLine());

        media = (nota1 + nota2)/2;

        if (media >= 9 && media <= 10){

            Console.WriteLine("Nota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media + "\nConceito: A" + "\nSituação: APROVADO"); 
            
        }
        else if (media >= 7.5 && media < 9){

            Console.WriteLine("Nota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media + "\nConceito: B" + "\nSituação: APROVADO");
            
        }
        else if (media >= 6 && media < 7.5){

            Console.WriteLine("Nota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media + "\nConceito: C" + "\nSituação: APROVADO");
        }
        else if (media >= 4 && media < 6){

            Console.WriteLine("Nota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media + "\nConceito: D" + "\nSituação: REPROVADO");
            
        }
        else if (media >= 0 && media < 4){
            
            Console.WriteLine("Nota 1: " + nota1 + "\nNota 2: " + nota2 + "\nMédia: " + media + "\nConceito: E" + "\nSituação: REPROVADO");

        }
        else{

            Console.WriteLine("Informe um valor válido !");
            
        }
    }
}
    