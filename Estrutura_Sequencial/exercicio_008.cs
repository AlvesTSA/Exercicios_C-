//Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.Calcule e mostre o total do seu salário no referido mês.

using System;

class Exercicio_8{
    
    static void Main(){
        
        float ganho_hora, hora_mes, salario;
        
        Console.WriteLine("Informe quanto você ganha por hora: ");
        ganho_hora = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe quantas horas trabalhou no mes: ");
        hora_mes = float.Parse(Console.ReadLine());
        
        salario = ganho_hora*hora_mes;
        
        Console.WriteLine("Seu salario é: "+ salario);
        
        
    }
}    

