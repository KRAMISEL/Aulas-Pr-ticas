using System;
class vetor{
    static void Main(){
        float A = 3f,B;
        float[,] núm = new float[(int)A,(int)A];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                núm[i,ia] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("\nOrdem inserida.:\n=============================\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=============================");
        for(int i = 0; i < (int)A >> 1; i++){
            for(int ia = 0; ia < A; ia++){
                if(núm[i,ia] * 2 > A * A){
                    break;
                }
                B = núm[i,ia];
                núm[i,ia] = núm[((int)A - 1) - i,((int)A - 1) - ia];
                núm[((int)A - 1) - i,((int)A - 1) - ia] = B;
            }
        }
        Console.Write("\nOrdem invertida.:\n=============================\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < A; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=============================");
    }
}