/*Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda, 8% para o INSS e 5% para o sindicato, faça um programa que nos dê:
a)salário bruto.
b)quanto pagou ao INSS.
c)quanto pagou ao sindicato.
d)quanto pagou de IR.
e)desconto total.
f)o salário líquido.
calcule os descontos e o salário líquido, conforme a tabela abaixo:
+ Salário Bruto : R$
- IR (11%) : R$
- INSS (8%) : R$
- Sindicato ( 5%) : R$
= Salário Liquido : R$
Obs.: Salário Bruto - Descontos = Salário Líquido.*/

using System;

class Exercicio_15{

    static void Main(){

        double salario_bruto = 0;
        double salario_liquido = 0;
        double desconto_inss = 0;
        double desconto_sin = 0;
        double desconto_ir = 0;
        double desconto_total = 0;
        double ganho_hora = 0;
        double hora_mes = 0;

        Console.Write("Informe quanto você ganha por hora: ");
        ganho_hora = double.Parse(Console.ReadLine());

        Console.Write("Informe quantas horas trabalhou no mes: ");
        hora_mes = double.Parse(Console.ReadLine());

        salario_bruto = ganho_hora*hora_mes;
        desconto_inss = salario_bruto*0.08;
        desconto_sin = salario_bruto*0.05;
        desconto_ir = salario_bruto*0.11;
        desconto_total = desconto_inss + desconto_ir + desconto_sin;
        salario_liquido = salario_bruto - desconto_total;

        Console.WriteLine("Salário bruto R$: " + salario_bruto);
        Console.WriteLine("Desconto INSS R$: " + desconto_inss);
        Console.WriteLine("Desconto sindicato R$: " + desconto_sin);
        Console.WriteLine("Desconto IR R$: " + desconto_ir);
        Console.WriteLine("Desconto total R$: " + desconto_total);
        Console.WriteLine("Salário líquido R$: " + salario_liquido);

    }
}