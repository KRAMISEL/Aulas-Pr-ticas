using System;
class program{
    static void Main(){
      Console.Write("Por favor, escolha qual é o produto que deseja comprar: ");
      Console.WriteLine("Por favor, escolha qual é o produto que deseja comprar: ");
      double Feijão = 7;
      Console.Write("Feijão R$" + Feijão + "  ");
      Console.Write("Feijão por R${0}--",Feijão);
      double Arroz = 6;
      Console.WriteLine("Arroz R$" + Arroz);
      Console.WriteLine("Arroz por R${0}",Arroz);
      double Carne = 12;
      Console.Write("Carne R$" + Carne + "  ");
      Console.Write("Carne por R${0}--",Carne);
      double Cuzcuz = 8;
      Console.WriteLine("Cuzcuz R$" + Cuzcuz);
      Console.WriteLine("Cuzcuz por R${0}",Cuzcuz);
      string Produto = Console.ReadLine();
      if(Produto == "Feijão"){
        Console.WriteLine("Este produto tem 5% de desconto e ficará custando R$" + Feijão * 0.95);
        Console.WriteLine("Este produto tem 5% de desconto e ficará custando R${0}",Feijão * 0.95);
      }
      else if(Produto == "Arroz"){
        Console.WriteLine("Este produto tem 10% de desconto e ficará custando R$" + Arroz * 0.9);
        Console.WriteLine("Este produto tem 10% de desconto e ficará custando R${0}",Arroz * 0.9);
      }
      else if(Produto == "Carne"){
        Console.WriteLine("Este produto tem 5% de desconto e ficará custando R$" + Carne * 0.95);
        Console.WriteLine("Este produto tem 5% de desconto e ficará custando R${0}",Carne * 0.95);
      }
      else if(Produto == "Cuzcuz"){
        Console.WriteLine("Este produto por enquanto não possui desconto e ficará custando R$" + Cuzcuz);
        Console.WriteLine("Este produto por enquanto não possui desconto e ficará custando R${0}",Cuzcuz);
      }
    }
}