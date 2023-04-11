//Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].

using System;

class Exercicio_2 {
    
  static void Main() {
      
        float num;
      
        Console.WriteLine("Informe um número qualquer: ");
        num = float.Parse(Console.ReadLine());
    
        Console.WriteLine("O número informado foi: " + num);
    
  }
}