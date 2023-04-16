using System;
class program{
    static void Main(){
      Console.Write("A quantos Kmh seu carro está? ");
      int Kmh = int.Parse(Console.ReadLine());
      if(Kmh > 80){
        Console.WriteLine("Você receberá uma multa de R${0},00 por cada Km acima da velocidade permitida.",(Kmh - 80) * 5);
      }
      else{
        Console.WriteLine("Seu carro está a uma velocidade aceitável.");
      }
    }
}