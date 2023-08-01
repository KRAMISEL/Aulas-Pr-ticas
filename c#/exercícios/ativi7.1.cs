using System;
class impreção{
    static void Main(){
        int A = 0;
        Console.WriteLine("Primeiro:");
        for(int i = 0; i <= 100; i++){
            Console.WriteLine(A = i);
        }
        Console.WriteLine("Segundo:");
        for(int i = 0; i <= 1000; i += 10){
            Console.WriteLine(i * 0.1);
        }
        Console.WriteLine("Terceiro:");
        for(int i = 100; i >= 0; i--){
            Console.WriteLine(A - i);
        }
    }
}