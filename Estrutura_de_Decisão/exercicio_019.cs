/*Faça um Programa que peça uma data no formato dd/mm/aaaa e determine se a mesma é uma data válida.*/

using System;

class exercicio_019{

    static void Main(){

        int dia = 0;
        int mes = 0;
        int ano = 0;
        bool data = true;

        Console.WriteLine("Informe uma data dd/mm/aaaa: ");
        dia = int.Parse(Console.ReadLine()); 
        mes = int.Parse(Console.ReadLine()); 
        ano = int.Parse(Console.ReadLine());;

        if (ano < 0) {

            data = false;
        } 
        else if (mes <= 0 || mes > 12) {

            data = false;

        }
        else if (dia <= 0 || dia > 31) {

            data = false;

        } 
        else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30) {
            data = false;

        } 
        else if (mes == 2) {

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) {

                if (dia > 29) {

                    data = false;
                }
            }
            else {

                if (dia > 28) {

                    data = false;
                }
            }
        }

        if (data) {

            Console.WriteLine("Data: " + dia.ToString("00") + "/" + mes.ToString("00") + "/" + ano.ToString("0000"));
            
        } 
        else {

            Console.WriteLine("Data inválida! Tente novamente.");
        }
    }
}