using System;
class Programa{
    static void Main(){
        int a = 4;
        int C = 0;
        int D = 0;
        int[,] números = new int[a,a];
        Console.WriteLine("Digite números:");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                números[A,B] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("====================>\nNúmeros digitados:");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                Console.Write(" {0} ",números[A,B]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================>");
        Console.WriteLine("====================>\n");
        Console.WriteLine("Números pares:");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                if(números[A,B] % 2 == 0){
                    Console.Write(" {0} ",números[A,B]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================>\n");
        Console.WriteLine("Números ímpares:");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                if(números[A,B] % 2 != 0){
                    Console.Write(" {0} ",números[A,B]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("====================>\n");
        Console.WriteLine("Média dos números ímpares:");
        for(int A = 0; A < a; A++){
            for(int B = 0; B < a; B++){
                if(números[A,B] % 2 != 0){
                    C += números[A,B];
                    D++;
                }
            }
        }
        Console.WriteLine(C / D);
        Console.WriteLine("====================>");
    }
}