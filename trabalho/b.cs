using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1;
    static int excluirCadastro;
    static int[] excluirCadastro1;
    static int A;
    static int N_deCadastros;
    static void Main(){
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("O que deseja fazer?\n[C/E]");
        char cadastrosnovos = char.Parse(Console.ReadLine());
        if(cadastrosnovos == 'C' || cadastrosnovos == 'c'){
            Cadastrar();
        }
        else{
            Excluircadastro();
        }
    }
    static void Cadastrar(){
        if(quantidadeDeCadastro > 0){
            Console.WriteLine("Deseja fazer novos cadastros?\n[S/N]");
            char cadastrosnovos = char.Parse(Console.ReadLine());
            if(cadastrosnovos == 'S' || cadastrosnovos == 's'){
                Novoscadastros();
                goto avançar;
            }
            else{
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
            Console.WriteLine();
        }
        avançar1:
        avançar:
        Main();
    }
    static void Novoscadastros(){
        int[] armazenamentoDeCadastros = new int[quantidadeDeCadastro1.Length];
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
            armazenamentoDeCadastros[A] = quantidadeDeCadastro1[A];
        }
        Console.Write("Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro2 = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length + quantidadeDeCadastro2];
        for(A = 0; A < quantidadeDeCadastro1.Length - quantidadeDeCadastro2; A++){
            quantidadeDeCadastro1[A] = armazenamentoDeCadastros[A];
        }
        for(A = 0; A < quantidadeDeCadastro2; A++){
            N_deCadastros++;
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.Write(": ");
            quantidadeDeCadastro1[A + quantidadeDeCadastro1.Length - quantidadeDeCadastro2] = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.WriteLine(quantidadeDeCadastro1[A]);
            Console.WriteLine();
        }
    }
    static void Excluircadastro(){
        int excluirCadastro2;
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            Console.WriteLine();
            goto avançar;
        }
        else if(excluirCadastro > 0){
            Console.Write("Quantos cadastros deseja excluir: ");
            excluirCadastro2 = int.Parse(Console.ReadLine());
            excluirCadastro1 = new int[excluirCadastro1.Length + excluirCadastro2];
            Console.WriteLine();
        for(int B = 0; B < excluirCadastro2; B++){
            Console.Write("Qual cadastro deseja excluir: ");
            int exCadastro1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int Ab = quantidadeDeCadastro1[exCadastro1 - 1];
        for(int Ba = exCadastro1 - 1; Ba < quantidadeDeCadastro1.Length - 1; Ba++){
            quantidadeDeCadastro1[Ba] = quantidadeDeCadastro1[Ba + 1];
        }
            quantidadeDeCadastro1[quantidadeDeCadastro1.Length - 1] = 0;
            Console.WriteLine("Cadastro de número ({0}) excluido.",N_deCadastros = exCadastro1);
            Console.WriteLine();
        }
        if(quantidadeDeCadastro1[quantidadeDeCadastro1.Length - 1] == 0){
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length - excluirCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.Write("Cadastro de número ({0}):",N_deCadastros + 1);
            Console.WriteLine("{0}",quantidadeDeCadastro1[A]);
            Console.WriteLine();
        }
            goto avançar1;
        }
        }
        Console.Write("Quantos cadastros deseja excluir: ");
        excluirCadastro = int.Parse(Console.ReadLine());
        excluirCadastro1 = new int[excluirCadastro];
        Console.WriteLine();
        for(int B = 0; B < excluirCadastro1.Length; B++){
            Console.Write("Qual cadastro deseja excluir: ");
            int exCadastro = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int Aa = quantidadeDeCadastro1[exCadastro - 1];
        for(int Ba = exCadastro - 1; Ba < quantidadeDeCadastro1.Length - 1; Ba++){
            quantidadeDeCadastro1[Ba] = quantidadeDeCadastro1[Ba + 1];
        }
            quantidadeDeCadastro1[quantidadeDeCadastro1.Length - 1] = 0;
            Console.WriteLine("Cadastro de número ({0}) excluido.",N_deCadastros = exCadastro);
            Console.WriteLine();
        }
        if(quantidadeDeCadastro1[quantidadeDeCadastro1.Length - 1] == 0){
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length - excluirCadastro; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.Write("Cadastro de número ({0}):",N_deCadastros + 1);
            Console.WriteLine("{0}",quantidadeDeCadastro1[A]);
            Console.WriteLine();
        }
            goto avançar2;
        }
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("Cadastro de número ({0}):",N_deCadastros + 1);
            Console.WriteLine(":{0}",quantidadeDeCadastro1[A]);
            Console.WriteLine();
        }
        avançar:
        avançar1:
        avançar2:
        Main();
    }
}