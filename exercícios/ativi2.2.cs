using System;
class Programa{
    static void Main(){
        int[,] números = new int[4,4];
        Console.WriteLine("Digite números:");
        for(int A = 0; A < 4; A++){
            for(int B = 0; B < 4; B++){
                números[A,B] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("====================>");
        for(int A = 0; A < 4; A++){
            for(int B = 0; B < 4; B++){
                Console.WriteLine(números[A,B]);
            }
        }
        Console.WriteLine("====================>");
    }
}