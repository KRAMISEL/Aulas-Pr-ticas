using System;
class exemplo{
    static void Main(){
        voltar:
        Console.Write("Digite um número de 1 a 12:");
        int número = Convert.ToInt32(Console.ReadLine());
        switch(número){
            case 1:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 2:
            Console.WriteLine("\nEsse número corresponde ao mês de Fevereiro.");
            break;
            case 3:
            Console.WriteLine("\nEsse número corresponde ao mês de março.");
            break;
            case 4:
            Console.WriteLine("\nEsse número corresponde ao mês de Abril.");
            break;
            case 5:
            Console.WriteLine("\nEsse número corresponde ao mês de maio.");
            break;
            case 6:
            Console.WriteLine("\nEsse número corresponde ao mês de Junho.");
            break;
            case 7:
            Console.WriteLine("\nEsse número corresponde ao mês de Julho.");
            break;
            case 8:
            Console.WriteLine("\nEsse número corresponde ao mês de Agosto.");
            break;
            case 9:
            Console.WriteLine("\nEsse número corresponde ao mês de Setembro.");
            break;
            case 10:
            Console.WriteLine("\nEsse número corresponde ao mês de Outubro.");
            break;
            case 11:
            Console.WriteLine("\nEsse número corresponde ao mês de Novembro.");
            break;
            case 12:
            Console.WriteLine("\nEsse número corresponde ao mês de Dezembro.");
            break;
            default:
            Console.WriteLine("\nNúmero errado.");
            Console.ReadLine();
            goto voltar;
        }
    }
}