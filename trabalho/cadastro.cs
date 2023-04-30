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
        Console.WriteLine();
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
        if(quantidadeDeCadastro == 0){
        Main();
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
        Main();
    }
    static void Alterarcadastro(ref string[] nomeAl,ref int[] idadeAl,ref double[] pesoAl,ref double[] alturaAl,ref char[] sexoAl){
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem alterados.");
            Console.WriteLine();
            goto avançar;
        }
        if(quantidadeDeCadastro1.Length == 1){
        int Aa = 0;
        Console.Write("Digite o seu nome: ");
        nomeAl[Aa] = Console.ReadLine();
        Console.Write("Digite a sua idade: ");
        idadeAl[Aa] = int.Parse(Console.ReadLine());
        Console.Write("Digite o seu peso: ");
        pesoAl[Aa] = double.Parse(Console.ReadLine());
        Console.Write("Digite a sua altura: ");
        alturaAl[Aa] = double.Parse(Console.ReadLine());
        Console.Write("Digite o seu sexo: ");
        sexoAl[Aa] = char.Parse(Console.ReadLine());
        Console.WriteLine("Cadastro de número ({0}) alterado.",N_deCadastros = A);
        Console.WriteLine();
        goto avançar1;
        }
        retorno:
        Console.Write("Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] alterarCadastro1 = new int[alterarCadastro];
        Console.WriteLine();
        if(alterarCadastro > A){
            Console.WriteLine("A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        else if(alterarCadastro == 0){
        goto avançar2;
        }
        else if(alterarCadastro == quantidadeDeCadastro1.Length){
        for(int D = 0; D < alterarCadastro1.Length; D++){
        Console.Write("Digite o seu nome: ");
        nomeAl[D] = Console.ReadLine();
        Console.Write("Digite a sua idade: ");
        idadeAl[D] = int.Parse(Console.ReadLine());
        Console.Write("Digite o seu peso: ");
        pesoAl[D] = double.Parse(Console.ReadLine());
        Console.Write("Digite a sua altura: ");
        alturaAl[D] = double.Parse(Console.ReadLine());
        Console.Write("Digite o seu sexo: ");
        sexoAl[D] = char.Parse(Console.ReadLine());
        Console.WriteLine("Cadastro de número ({0}) alterado.",N_deCadastros = D + 1);
        Console.WriteLine();
        }
        goto avançar3;
        }
        voltar:
        for(int B = 0; B < alterarCadastro1.Length; B++){
        Console.Write("Qual cadastro deseja alterar: ");
        Console.WriteLine("(Observação.: Insira o índice do Cadastro reduzindo o número do cadastro em 1.)");
        int C = int.Parse(Console.ReadLine());
        if(C >= quantidadeDeCadastro1.Length){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar;
        }
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
        Console.WriteLine("Cadastro de número ({0}) alterado.",N_deCadastros = C + 1);
        Console.WriteLine();
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Imprimirtodososcadastros(){
        N_deCadastros = 0;
        if(A == 0){
        Console.WriteLine("Não existem cadastros a serem imprimidos.");
        Console.WriteLine();
        goto avançar;
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
        avançar:
        Main();
    }
    static void Imprimirumcadastro(int Aa){
        if(A == 0){
        Console.WriteLine("Não existem cadastros a serem imprimidos.");
        Console.WriteLine();
        goto avançar;
        }
        N_deCadastros = -1;
        if(quantidadeDeCadastro1.Length == 1){
        int B = 0;
        Console.WriteLine("Cadastro de número ({0}):",N_deCadastros + 2);
        Console.WriteLine("Nome:{0}",nome[B]);
        Console.WriteLine("Idade:{0}",idade[B]);
        Console.WriteLine("Peso:{0}",peso[B]);
        Console.WriteLine("Altura:{0}",altura[B]);
        Console.WriteLine("Sexo:{0}",sexo[B]);
        Console.WriteLine();
        goto avançar1;
        }
        voltar:
        Console.Write("Qual cadastro deseja imprimir: ");
        Console.WriteLine("(Observação.: Insira o índice do Cadastro reduzindo o número do cadastro em 1.)");
        Aa = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if(Aa >= quantidadeDeCadastro1.Length){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar;
        }
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
        avançar:
        avançar1:
        Main();
    }
    static void Excluircadastro(){
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem excluidos.");
            Console.WriteLine();
            goto avançar;
        }
        if(quantidadeDeCadastro1.Length == 1){
            goto avançar1;
        }
        retorno:
        Console.Write("Quantos cadastros deseja excluir: ");
        int excluirCadastro = int.Parse(Console.ReadLine());
        int[] excluirCadastro1 = new int[excluirCadastro];
        Console.WriteLine();
        if(excluirCadastro > A){
            Console.WriteLine("A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        else if(excluirCadastro == 0){
        goto avançar2;
        }
        else if(excluirCadastro == quantidadeDeCadastro1.Length){
            goto avançar3;
        }
        voltar:
        Console.Write("Qual cadastro deseja excluir: ");
        Console.WriteLine("(Observação.: Insira o índice do Cadastro reduzindo o número do cadastro em 1.)");
        int Aa = int.Parse(Console.ReadLine());
        if(Aa >= quantidadeDeCadastro1.Length){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar;
        }
        //
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Limpartela(){
        Console.Clear();
        Main();
    }
    static void Sair(){
        Console.WriteLine("Agradeçemos pela pressença, volte sempre.");
        Console.Write(" ");
    }   
}