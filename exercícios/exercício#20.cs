using System;
class program{
   static void Main(){
      Console.Write("Digite algum número:");
      float num = float.Parse(Console.ReadLine());
      if(num % 2 == 0){
         Console.WriteLine("Este número é par.");
      }
      else if(num % 3 == 0){
         Console.WriteLine("Este número é ímpar.");
      }
   }
}