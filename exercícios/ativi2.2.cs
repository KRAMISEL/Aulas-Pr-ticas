using System;
class Programa{
    static void Main(){
        int A = 4;
        int[,] números = new int[A,A];
        Console.WriteLine("Digite números:");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                números[i,ia] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("====================>");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write(" {0}",números[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================>");
    }
}