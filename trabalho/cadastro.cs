using System;
class program{
    static int[] quantidadeDeCadastro1;
    static string[] nome;
    static int[] idade;
    static double[] peso;
    static double[] altura;
    static char[] sexo;
    static int N_deCadastros;
    static int A;
    static void Main(){
        Console.WriteLine("O que deseja fazer:");
        Console.WriteLine();
        Menu();
        Console.Write(" ");
    }
    static void Menu(){
        Console.WriteLine("(1) Cadastro;\n(2) Alterar cadastro;\n(3) Imprimir todos os cadastros;\n(4) Imprimir um cadastro;\n(5) Excluir cadastro;\n(6) Limpar tela;\n(7) Sair;");
        string execução = Console.ReadLine();
        switch(execução){
            case  "1":
            Cadastro();
            break;
            case  "2":
            Alterarcadastro(ref nome,ref idade,ref peso,ref altura,ref sexo);
            break;
            case  "3":
            Imprimirtodososcadastros();
            break;
            case  "4":
            Imprimirumcadastro(A);
            break;
            case  "5":
            Excluircadastro();
            break;
            case  "6":
            Limpartela();
            break;
            case  "7":
            Sair();
            break;
            default:
            Console.Clear();
            Main();
            break;
        }
    }
    static void Cadastro(){
        N_deCadastros = 0;
        Console.Write("Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro];
        Console.WriteLine();
        if(quantidadeDeCadastro < 1){
            goto ir;
        }
        nome = new string[quantidadeDeCadastro];
        idade = new int[quantidadeDeCadastro];
        peso = new double[quantidadeDeCadastro];
        altura = new double[quantidadeDeCadastro];
        sexo = new char[quantidadeDeCadastro];
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
            if(N_deCadastros < A){
                N_deCadastros++;
            }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.Write("Digite o seu nome: ");
            nome[A] = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade[A] = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            peso[A] = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            altura[A] = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            sexo[A] = char.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        ir:
        voltar:
        Console.WriteLine("Voltar para o menu?");
        Console.WriteLine("[S/s]");
        char voltar = char.Parse(Console.ReadLine());
        Console.WriteLine();
        if(voltar == 'S' || voltar == 's'){
            Main();
        }
        else{
            goto voltar;
        }
    }
    static void Alterarcadastro(ref string[] nomeAl,ref int[] idadeAl,ref double[] pesoAl,ref double[] alturaAl,ref char[] sexoAl){
        if(A == 0){
            Console.WriteLine("Você não possui cadastros para alterar.");
            Console.WriteLine();
            Main();
        }
        retorno:
        Console.Write("Quantos cadastros deseja alterar:");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] alterarCadastro1 = new int[alterarCadastro];
        Console.WriteLine();
        if(alterarCadastro > A){
            Console.WriteLine("A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        else if(alterarCadastro == 0){
        retorno1:
        Console.WriteLine("Voltar para o menu?");
        Console.WriteLine("[S/s]");
        char voltar = char.Parse(Console.ReadLine());
        Console.WriteLine();
        if(voltar == 'S' || voltar == 's'){
            Main();
        }
        else{
            goto retorno1;
        }
        }
        for(int B = 0; B < alterarCadastro1.Length; B++){
        Console.Write("Qual cadastro deseja alterar: ");
        Console.WriteLine("(Observação.: Reduza o número do cadastro em 1.)");
        int C = int.Parse(Console.ReadLine());
        Console.Write("Digite o seu nome: ");
        nomeAl[C] = Console.ReadLine();
        Console.Write("Digite a sua idade: ");
        idadeAl[C] = int.Parse(Console.ReadLine());
        Console.Write("Digite o seu peso: ");
        pesoAl[C] = double.Parse(Console.ReadLine());
        Console.Write("Digite a sua altura: ");
        alturaAl[C] = double.Parse(Console.ReadLine());
        Console.Write("Digite o seu sexo: ");
        sexoAl[C] = char.Parse(Console.ReadLine());
        Console.WriteLine("Cadastro de número ({0}) alterado.",N_deCadastros = C);
        Console.WriteLine();
        }
        retorno2:
        Console.WriteLine("Voltar para o menu?");
        Console.WriteLine("[S/s]");
        char voltar1 = char.Parse(Console.ReadLine());
        Console.WriteLine();
        if(voltar1 == 'S' || voltar1 == 's'){
            Main();
        }
        else{
            goto retorno2;
        }
    }
    static void Imprimirtodososcadastros(){
        N_deCadastros = 0;
        if(A == 0){
        Console.WriteLine("Você não possui cadastros existentes.");
        Console.WriteLine();
        Main();
        }
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
        Console.WriteLine("Cadastro de número ({0}):",N_deCadastros + 1);
        Console.WriteLine("Nome:{0}",nome[A]);
        Console.WriteLine("Idade:{0}",idade[A]);
        Console.WriteLine("Peso:{0}",peso[A]);
        Console.WriteLine("Altura:{0}",altura[A]);
        Console.WriteLine("Sexo:{0}",sexo[A]);
        Console.WriteLine();
        }
        retorno:
        Console.WriteLine("Voltar para o menu?");
        Console.WriteLine("[S/s]");
        char voltar = char.Parse(Console.ReadLine());
        Console.WriteLine();
        if(voltar == 'S' || voltar == 's'){
            Main();
        }
        else{
            goto retorno;
        }
    }
    static void Imprimirumcadastro(int Aa){
        N_deCadastros = 0;
        Console.Write("Qual cadastro deseja imprimir: ");
        Console.WriteLine("(Observação.: Reduza o número do cadastro em 1.)");
        Aa = int.Parse(Console.ReadLine());
        while(N_deCadastros < Aa){
            N_deCadastros++;
        }
        Console.WriteLine("Cadastro de número ({0}):",N_deCadastros + 1);
        Console.WriteLine("Nome:{0}",nome[Aa]);
        Console.WriteLine("Idade:{0}",idade[Aa]);
        Console.WriteLine("Peso:{0}",peso[Aa]);
        Console.WriteLine("Altura:{0}",altura[Aa]);
        Console.WriteLine("Sexo:{0}",sexo[Aa]);
        Console.WriteLine();
        retorno:
        Console.WriteLine("Voltar para o menu?");
        Console.WriteLine("[S/s]");
        char voltar = char.Parse(Console.ReadLine());
        Console.WriteLine();
        if(voltar == 'S' || voltar == 's'){
            Main();
        }
        else{
            goto retorno;
        }
    }
    static void Excluircadastro(){
    }
    static void Limpartela(){
        Console.Clear();
        retorno:
        Console.WriteLine("Voltar para o menu?");
        Console.WriteLine("[S/s]");
        char voltar = char.Parse(Console.ReadLine());
        Console.WriteLine();
        if(voltar == 'S' || voltar == 's'){
            Main();
        }
        else{
            goto retorno;
        }
    }
    static void Sair(){
        Console.WriteLine("Agradeçemos pela pressença, volte sempre.");
        Console.Write(" ");
    }   
}