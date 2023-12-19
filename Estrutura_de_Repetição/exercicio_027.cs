/*27. Faça um programa que calcule o número médio de alunos por turma. Para isto, peça a quantidade de turmas e a quantidade de alunos para cada turma. As turmas não podem ter mais de 40 alunos.*/

using System;

public class exercicio_027{

    static void Main(){

        int turma = 0;
        int aluno = 0;
        int soma = 0;
        int media = 0;

        Console.WriteLine("Informe a quantidade de turmas: ");
        turma = int.Parse(Console.ReadLine());

        for (int i = 1; i <= turma; i++){
            
            Console.WriteLine("Informe a quantidade de alunos da turma " + i + ":");
            do{

                aluno = int.Parse(Console.ReadLine());

                if (aluno > 40){
                
                    Console.WriteLine("Erro: a turma não deve ultrapassar 40 alunos.");

                }  

            } while (aluno > 40);

            soma += aluno; 
        }

        media = soma/turma;

        Console.WriteLine("Numero medio de alunos por turma: " + media);
    }
}