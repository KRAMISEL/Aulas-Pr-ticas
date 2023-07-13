using System;
class vetor{
    static void Main(){
        float A = 3f,B = 2f,C;
        float[,] núm = new float[(int)A,(int)B];
        Console.WriteLine("Preencha o vetor com números.");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                núm[i,ia] = int.Parse(Console.ReadLine());
            }
        }
        Console.Write("\nOrdem inserida.:\n=============================\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=============================");
        for(int i = 0; i < A / 2; i++){
            for(int ia = 0; ia < B; ia++){
                if(núm[i,ia] * 2 > A * B){
                    break;
                }
                else if(núm[i,ia] * 2 == A * B){
                    C = núm[i,ia];
                    núm[i,ia] = núm[((int)A - 1) - i,((int)B - 1) - ia];
                    núm[((int)A - 1) - i,((int)B - 1) - ia] = C;
                    break;
                }
                C = núm[i,ia];
                núm[i,ia] = núm[((int)A - 1) - i,((int)B - 1) - ia];
                núm[((int)A - 1) - i,((int)B - 1) - ia] = C;
            }
        }
        Console.Write("\nOrdem invertida.:\n=============================\n");
        for(int i = 0; i < A; i++){
            for(int ia = 0; ia < B; ia++){
                Console.Write(" {0}",núm[i,ia]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("=============================");
    }
}