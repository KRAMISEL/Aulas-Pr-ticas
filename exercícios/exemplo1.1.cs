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
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 3:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 4:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 5:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 6:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 7:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 8:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 9:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 10:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 11:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            case 12:
            Console.WriteLine("\nEsse número corresponde ao mês de Janeiro.");
            break;
            default:
            Console.WriteLine("\nNúmero errado.");
            Console.ReadLine();
            goto voltar;
        }
    }
}