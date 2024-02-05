/*12. Foram anotadas as idades e alturas de 10 alunos. Faça um Programa que determine quantos alunos com mais de 13 anos possuem altura inferior à média de altura desses alunos.*/

using System;

class exercicio_012{

    static void Main(){

        int[] idade = new int[10];
        float[] altura = new float[10];
        float media = 0;

        for (int i = 0; i < 10; i++){
            
            Console.Write("Informe a idade do aluno " + (i + 1) + ": ");
            idade[i] = int.Parse(Console.ReadLine());
            Console.Write("Informe a altura do aluno " + (i + 1) + ": ");
            altura[i] = float.Parse(Console.ReadLine());
            media += altura[i];
        }

        media /= 10;
        int count_aluno = 0;

        for (int i = 0; i < 10; i++){
            
            if (idade[i] > 13 && altura[i] < media){
                
                count_aluno++;
            }
        }

        Console.Write("Quantidade de alunos maiores de 13 anos com altura abaixo da media: " + count_aluno);
    }
}