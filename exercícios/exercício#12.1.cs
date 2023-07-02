using System;
class program{
  static void Main(){
    Console.WriteLine("Por favor, escolha qual é o produto que deseja comprar: ");
    float Feijão = 7;
    Console.Write("Feijão por {0:c}--",Feijão);
    float Arroz = 6;
    Console.WriteLine("Arroz por {0:c}",Arroz);
    float Carne = 12;
    Console.Write("Carne por {0:c}--",Carne);
    float Cuzcuz = 8;
    Console.WriteLine("Cuzcuz por {0:c}",Cuzcuz);
    string Produto = Console.ReadLine();
    if(Produto == "Feijão"){
      Console.WriteLine("Este produto tem 5% de desconto e ficará custando {0:c}",Feijão * 0.95f);
    }
    else if(Produto == "Arroz"){
      Console.WriteLine("Este produto tem 10% de desconto e ficará custando {0:c}",Arroz * 0.9f);
    }
    else if(Produto == "Carne"){
      Console.WriteLine("Este produto tem 5% de desconto e ficará custando {0:c}",Carne * 0.95f);
    }
    else if(Produto == "Cuzcuz"){
      Console.WriteLine("Este produto por enquanto não possui desconto e ficará custando {0:c}",Cuzcuz);
    }
  }
}