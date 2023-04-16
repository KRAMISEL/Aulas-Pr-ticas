using System;
class program{
    static void Main(){
      Console.WriteLine("Digite o seu nome e o seu sexo:");
      string nome = Console.ReadLine();
      string sexo = Console.ReadLine();
      Console.WriteLine("Por favor, escolha qual é o produto que deseja comprar: ");
      double Feijão = 7;
      Console.Write("Feijão R${0} ",Feijão);
      double Arroz = 6;
      Console.WriteLine("Arroz R${0}",Arroz);
      string Produto = Console.ReadLine();
      if(sexo == "Homem" &&  Produto == "Feijão"){
        Console.WriteLine("O seu nome é {0} e o produto selecionado tem 5% de desconto e ficará custando R${1}",nome,Feijão*0.95);
      }
      else if(sexo == "Homem"  && Produto == "Arroz"){
        Console.WriteLine("O seu nome é {0} e o produto selecionado tem 5% de desconto e ficará custando R${1}",nome,Arroz*0.95);
      }
      else if(sexo == "Mulher"  && Produto == "Feijão"){
        Console.WriteLine("O seu nome é {0} e o produto selecionado tem 13% de desconto e ficará custando R${1}",nome,Feijão*0.87);
      }
      else if(sexo == "Mulher"  && Produto == "Arroz"){
        Console.WriteLine("O seu nome é {0} e o produto selecionado tem 13% de desconto e ficará custando R${1}",nome,Arroz*0.87);
      }
    }
}