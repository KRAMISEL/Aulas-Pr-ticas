using System;
class program{
  static void Main(){
    Console.WriteLine("Digite o seu nome e o seu sexo:");
    string nome = Console.ReadLine();
    string sexo = Console.ReadLine();
    Console.WriteLine("Por favor, escolha qual é o produto que deseja comprar: ");
    float Feijão = 7f;
    Console.Write("Feijão {0:c} ",Feijão);
    float Arroz = 6f;
    Console.WriteLine("Arroz {0:c}",Arroz);
    string Produto = Console.ReadLine();
    if(sexo == "Homem" &&  Produto == "Feijão"){
      Console.WriteLine("O seu nome é {0} e o produto selecionado tem 5% de desconto e ficará custando {1:c}",nome,Feijão * 0.95f);
    }
    else if(sexo == "Homem"  && Produto == "Arroz"){
      Console.WriteLine("O seu nome é {0} e o produto selecionado tem 5% de desconto e ficará custando {1:c}",nome,Arroz * 0.95f);
    }
    else if(sexo == "Mulher"  && Produto == "Feijão"){
      Console.WriteLine("O seu nome é {0} e o produto selecionado tem 13% de desconto e ficará custando {1:c}",nome,Feijão * 0.87f);
    }
    else if(sexo == "Mulher"  && Produto == "Arroz"){
      Console.WriteLine("O seu nome é {0} e o produto selecionado tem 13% de desconto e ficará custando {1:c}",nome,Arroz * 0.87f);
    }
  }
}