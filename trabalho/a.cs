using System;
class program{

    static char Op;
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1;
    static int A;
    static int N_deCadastros;
    static void Main(){
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("Quantos cadastros deseja fazer: ");
        quantidadeDeCadastro = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro];
        Cadastrar();
        Console.WriteLine("deseja fazer um novo cadastro? [s/n]");
        Op = char.Parse(Console.ReadLine());
        if(Op == 's'){
            Novoscadastros();
        }
    }
    static void Cadastrar(){
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("{0} :",N_deCadastros + 1);
            quantidadeDeCadastro1[A] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("{0}",N_deCadastros + 1);
            Console.WriteLine(quantidadeDeCadastro1[A]);
        }
    }
    static void Novoscadastros(){
        Console.Write("Quantos cadastros deseja fazer: ");
        quantidadeDeCadastro = int.Parse(Console.ReadLine());
    
        Console.WriteLine("{0} :",N_deCadastros + 1);
        quantidadeDeCadastro1[quantidadeDeCadastro] = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 2);
            Console.WriteLine(quantidadeDeCadastro1[A]);
        }
    }
}