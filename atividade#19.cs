using System;
class program{
    static void Main(){
        Console.Write("Qual é o nome do aluno?");
      string nome = Console.ReadLine();
      Console.WriteLine("Quais são as notas do aluno?");
      double nota = double.Parse(Console.ReadLine());
      double nota1 = double.Parse(Console.ReadLine());
      Console.Clear();
      if((nota + nota1) / 2 >= 7){
        Console.WriteLine("O nome do aluno é {0} e a sua média foi de {1} pontos, e ele teve um ótimo aproveitamento.",nome,(nota+nota1)/2);
      }
      else{
        Console.WriteLine("O nome do aluno é {0} e a sua média foi de {1} pontos, e ele não teve um ótimo aproveitamento.",nome,(nota+nota1)/2);
      }
    }
}