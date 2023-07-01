using System;
class Números{
    static void Main(){
        Random random = new Random();
        int númbase = random.Next(12),A = 0,B = 0;
        float[] coleção;
        if(númbase < 3){
            númbase = 3;
        }
        coleção = new float[númbase];
        Console.WriteLine("Digite números aleatórios para completar a coleção:");
        for(int i = 0; i < coleção.Length; i++){
            coleção[i] = float.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("A coleção possui ao todo {0} números.",coleção.Length);
        Console.Write("\n>>");
        Console.ReadLine();
        Console.WriteLine("\nO primeiro número da coleção é {0}.\nO ultimo número da coleção é {1}.",coleção[A],coleção[B + coleção.Length - 1]);
        Console.Write("\n>>");
        Console.ReadLine();
        if(coleção.Length - 2 == 1){
            Console.Write("\nEntre os números {0} e {1}, existe {2} número, que é:",coleção[A],coleção[B + coleção.Length - 1],coleção.Length - 2);
        }
        else{
            Console.Write("\nEntre os números {0} e {1}, existem {2} números, que são:",coleção[A],coleção[B + coleção.Length - 1],coleção.Length - 2);
        }
        for(int i = 0; i < coleção.Length - 2; i++){
            Console.Write(" {0}",coleção[i + 1]);
        }
        Console.Write(".\n\n>>");
        Console.ReadLine();
        foreach(int i in coleção){
            if(i % 2 == 0){
                A++;
            }
            else{
                B++;
            }
        }
        if(A == 1){
            Console.WriteLine("\nA coleção possui {0} número par e {1} números ímpares.",A,B);
        }
        else if(B == 1){
            Console.WriteLine("\nA coleção possui {0} números pares e {1} número ímpar.",A,B);
        }
        else if(A == 0){
            Console.WriteLine("\nA coleção possui nenhum número par e {0} números ímpares.",B);
        }
        else if(B == 0){
            Console.WriteLine("\nA coleção possui {0} números pares e nenhum número ímpar.",A);
        }
        else{
            Console.WriteLine("\nA coleção possui {0} números pares e {1} números ímpares.",A,B);
        }
        Console.Write("\n>>");
        Console.ReadLine();
        Array.Sort(coleção);
        Console.WriteLine("\nO menor número da coleção é {0}.\nO maior número da coleção é {1}.",coleção[A = 0],coleção[(B = 0) + coleção.Length - 1]);
        Console.Write("\n>>");
        Console.ReadLine();
        Console.Write("\nA coleção ordenada crescentemente:");
        foreach(int i in coleção){
            Console.Write(" {0}",i);
        }
        Console.Write(".\n\n>>");
        Console.ReadLine();
        Array.Reverse(coleção);
        Console.Write("\nA coleção ordenada decrescentemente:");
        foreach(int i in coleção){
            Console.Write(" {0}",i);
        }
        Console.Write(".\n\nObrigado.\n");
    }
}