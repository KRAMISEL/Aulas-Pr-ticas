using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1;
    static int A;
    static int N_deCadastros;
    static void Main(){
        Console.WriteLine("A");
        Console.ReadLine();
        Cadastrar();
    }
    static void Cadastrar(){
        if(quantidadeDeCadastro > 1){
            Novoscadastros();
            goto avançar;
        }
        Console.Write("Quantos cadastros deseja fazer: ");
        quantidadeDeCadastro = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro];
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.Write(": ");
            quantidadeDeCadastro1[A] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        N_deCadastros -= A;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.WriteLine(quantidadeDeCadastro1[A]);
        }
        avançar:
        Main();
    }
    static void Novoscadastros(){
        Console.Write("Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro2 = int.Parse(Console.ReadLine());
        int Aa = quantidadeDeCadastro1.Length + quantidadeDeCadastro2;
        for(A = Aa; A < Aa - quantidadeDeCadastro2; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.Write(": ");
            quantidadeDeCadastro1[A] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        N_deCadastros -= A;
        for(A = 0; A < Aa; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 2);
            Console.WriteLine(quantidadeDeCadastro1[A]);
        }
    }
}