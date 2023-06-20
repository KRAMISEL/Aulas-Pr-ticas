using System;
class Programa{
    static void Main(){
        int[,] números = new int[4,4];
        Console.WriteLine("Digite números:");
        for(int A = 0; A < 4; A++){
            números[0,A] = int.Parse(Console.ReadLine());
        }
        for(int A = 0; A < 4; A++){
            números[1,A] = int.Parse(Console.ReadLine());
        }
        for(int A = 0; A < 4; A++){
            números[2,A] = int.Parse(Console.ReadLine());
        }
        for(int A = 0; A < 4; A++){
            números[3,A] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("====================>");
        for(int A = 0; A < 4; A++){
            Console.WriteLine(números[0,A]);
        }
        for(int A = 0; A < 4; A++){
            Console.WriteLine(números[1,A]);
        }
        for(int A = 0; A < 4; A++){
            Console.WriteLine(números[2,A]);
        }
        for(int A = 0; A < 4; A++){
            Console.WriteLine(números[3,A]);
        }
        Console.WriteLine("====================>");
    }
}