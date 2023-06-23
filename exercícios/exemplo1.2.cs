using System;
class exemplo{
    static void Main(){
        voltar:
        Console.Write("Digite um número de 1 a 12:");
        int número = Convert.ToInt32(Console.ReadLine());
        if(número == 1){
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
        }
        else if(número == 2){
            Console.WriteLine("\nEsse número corresponde ao mês de Fevereiro.");
        }
        else if(número == 3){
            Console.WriteLine("\nEsse número corresponde ao mês de março.");
        }
        else if(número == 4){
            Console.WriteLine("\nEsse número corresponde ao mês de Abril.");
        }
        else if(número == 5){
            Console.WriteLine("\nEsse número corresponde ao mês de maio.");
        }
        else if(número == 6){
            Console.WriteLine("\nEsse número corresponde ao mês de Junho.");
        }
        else if(número == 7){
            Console.WriteLine("\nEsse número corresponde ao mês de Julho.");
        }
        else if(número == 8){
            Console.WriteLine("\nEsse número corresponde ao mês de Agosto.");
        }
        else if(número == 9){
            Console.WriteLine("\nEsse número corresponde ao mês de Setembro.");
        }
        else if(número == 10){
            Console.WriteLine("\nEsse número corresponde ao mês de Outubro.");
        }
        else if(número == 11){
            Console.WriteLine("\nEsse número corresponde ao mês de Novembro.");
        }
        else if(número == 12){
            Console.WriteLine("\nEsse número corresponde ao mês de Dezembro.");
        }
        else{
            Console.WriteLine("\nNúmero errado.");
            Console.ReadLine();
            goto voltar;
        }
    }
}