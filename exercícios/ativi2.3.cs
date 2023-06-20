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
        Console.WriteLine("====================>\n");
        Console.WriteLine("Todos os números:");
        for(int A = 0; A < 4; A++){
            for(int B = 0; B < 4; B++){
                Console.WriteLine(números[A,B]);
            }
        }
        Console.WriteLine("====================>\n");
        Console.WriteLine("Números pares:");
        for(int A = 0; A < 4; A++){
            for(int B = 0; B < 4; B++){
                if(números[A,B] % 2 == 0){
                    Console.WriteLine(números[A,B]);
                }
            }
        }
        Console.WriteLine("====================>\n");
        Console.WriteLine("Números ímpares:");
        for(int A = 0; A < 4; A++){
            for(int B = 0; B < 4; B++){
                if(números[A,B] % 2 != 0){
                    Console.WriteLine(números[A,B]);
                }
            }
        }
        Console.WriteLine("====================>\n");
        Console.WriteLine("Média dos números ímpares:");
        int C = 0;
        int D = 0;
        for(int A = 0; A < 4; A++){
            for(int B = 0; B < 4; B++){
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