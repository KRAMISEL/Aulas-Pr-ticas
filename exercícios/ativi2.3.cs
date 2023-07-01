using System;
class Programa{
    static void Main(){
        int A = 4;
        int B = 0;
        int C = 0;
        int[,] números = new int[A,A];
        Console.WriteLine("Digite números:");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                números[i,ia] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("====================>\nNúmeros digitados:");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write(" {0} ",números[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================>\n\nNúmeros pares:");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                if(números[i,ia] % 2 == 0){
                    Console.Write(" {0} ",números[i,ia]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================>\n\nNúmeros ímpares:");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                if(números[i,ia] % 2 != 0){
                    Console.Write(" {0} ",números[i,ia]);
                }
            }
            Console.WriteLine();
        }
        Console.Write("====================>\n\nMédia dos números ímpares:");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                if(números[i,ia] % 2 != 0){
                    B += números[i,ia];
                    C++;
                }
            }
        }
        Console.WriteLine(B / C);
    }
}