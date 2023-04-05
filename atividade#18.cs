using System;
class program{
    static void Main(){
        Console.Write("Qual é o seu ano de nascimento? ");
      int Ano = int.Parse(Console.ReadLine());
      int Ano1 = 2023;
      if(Ano1 - Ano >= 16){
        Console.WriteLine("Você já pode votar.");
      }
      else{
        Console.WriteLine("Você ainda não pode votar.");
      }
    }
}