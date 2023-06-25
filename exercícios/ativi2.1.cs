using System;
class Programa{
    static void Main(){
        int A = 4;
        int[,] números = new int[A,A];
        Console.WriteLine("Digite números:");
        for(int i = 0; i < A; i++){
            números[0,i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < A; i++){
            números[1,i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < A; i++){
            números[2,i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0; i < A; i++){
            números[3,i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("====================>");
        for(int i = 0; i < A; i++){
            Console.WriteLine(números[0,i]);
        }
        for(int i = 0; i < A; i++){
            Console.WriteLine(números[1,i]);
        }
        for(int i = 0; i < A; i++){
            Console.WriteLine(números[2,i]);
        }
        for(int i = 0; i < A; i++){
            Console.WriteLine(números[3,i]);
        }
        Console.WriteLine("====================>");
    }
}