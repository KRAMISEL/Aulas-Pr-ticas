using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1;
    static int A;
    static int N_deCadastros;
    static void Main(){
        Console.WriteLine("--------------------------------------------");
        Cadastrar();
    }
    static void Cadastrar(){
        if(quantidadeDeCadastro > 1){
            Console.WriteLine("Deseja fazer novos cadastros?\n[S/N]");
            char cadastrosnovos = char.Parse(Console.ReadLine());
        if(cadastrosnovos == 'S' || cadastrosnovos == 's'){
            Novoscadastros();
            goto avançar;
        }
        else{
            Console.WriteLine();
            goto avançar1;
        }
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
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.WriteLine(quantidadeDeCadastro1[A]);
        }
        avançar1:
        avançar:
        Main();
    }
    static void Novoscadastros(){
        Console.Write("Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro2 = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro + quantidadeDeCadastro2];
        for(A = 0; A < quantidadeDeCadastro2; A++){
            N_deCadastros++;
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.Write(": ");
            quantidadeDeCadastro1[A] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.WriteLine(quantidadeDeCadastro1[A]);
        }
    }
}