using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1;
    static int excluirCadastro;
    static int[] excluirCadastro1 = new int[0];
    static string[] nome;
    static int[] idade;
    static double[] peso;
    static double[] altura;
    static char[] sexo;
    static int N_deCadastros;
    static int A;
    static int EX;
    static void Main(){
        Console.WriteLine("Atendimento de cadastro ao cliente.");
        Console.WriteLine("O que deseja fazer:");
        Console.WriteLine();
        Menu();
        Console.Write(" ");
    }
    static void Menu(){
        Console.WriteLine("(1) Cadastrar;\n(2) Alterar cadastro;\n(3) Imprimir todos os cadastros;\n(4) Imprimir um cadastro;\n(5) Excluir cadastro;\n(6) Limpar tela;\n(7) Sair;");
        string execução = Console.ReadLine();
        Console.WriteLine();
        switch(execução){
            case  "1":
            Cadastrar();
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
        }}
        N_deCadastros = 0;
        Console.Write("Quantos cadastros deseja fazer: ");
        quantidadeDeCadastro = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro];
        nome = new string[quantidadeDeCadastro];
        idade = new int[quantidadeDeCadastro];
        peso = new double[quantidadeDeCadastro];
        altura = new double[quantidadeDeCadastro];
        sexo = new char[quantidadeDeCadastro];
        Console.WriteLine();
        if(quantidadeDeCadastro == 0){
            goto avançar2;
        }
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
        avançar:
        avançar1:
        avançar2:
        Main();
    }
    static void Novoscadastros(){
        Console.Write("Quantos cadastros deseja fazer: ");
        int quantidadeDeCadastro2 = int.Parse(Console.ReadLine());
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length + quantidadeDeCadastro2];
        nome = new string[nome.Length + quantidadeDeCadastro2];
        idade = new int[idade.Length + quantidadeDeCadastro2];
        peso = new double[peso.Length + quantidadeDeCadastro2];
        altura = new double[altura.Length + quantidadeDeCadastro2];
        sexo = new char[sexo.Length + quantidadeDeCadastro2];
        for(A = 0; A < quantidadeDeCadastro2; A++){
            N_deCadastros++;
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.Write("Digite o seu nome: ");
            nome[A + nome.Length - quantidadeDeCadastro2] = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade[A + idade.Length - quantidadeDeCadastro2] = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            peso[A + peso.Length - quantidadeDeCadastro2] = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            altura[A + altura.Length - quantidadeDeCadastro2] = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            sexo[A + sexo.Length - quantidadeDeCadastro2] = char.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        N_deCadastros = 0;
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
        if(N_deCadastros < A){
            N_deCadastros++;
        }
            Console.WriteLine("({0})",N_deCadastros + 1);
            Console.WriteLine("nome:{0}",nome[A]);
            Console.WriteLine("Idade:{0}",idade[A]);
            Console.WriteLine("Peso:{0}",peso[A]);
            Console.WriteLine("Altura:{0}",altura[A]);
            Console.WriteLine("Sexo:{0}",sexo[A]);
            Console.WriteLine();
        }
    }
    static void Alterarcadastro(ref string[] nomeAl,ref int[] idadeAl,ref double[] pesoAl,ref double[] alturaAl,ref char[] sexoAl){
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem alterados.");
            Console.ReadLine();
            goto avançar;
        }
        else if(EX == 1){
        if(quantidadeDeCadastro1.Length - excluirCadastro1.Length == 0){
            Console.WriteLine("Não existem cadastros a serem alterados.");
            Console.ReadLine();
            goto avançar1;
        }}
        else if(quantidadeDeCadastro1.Length == 1){
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
            Console.WriteLine("Cadastro alterado.");
            Console.WriteLine();
            goto avançar2;
        }
        retorno:
        Console.Write("Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] alterarCadastro1 = new int[alterarCadastro];
        Console.WriteLine();
        if(alterarCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        else if(alterarCadastro == 0){
        goto avançar3;
        }
        else if(alterarCadastro1.Length == quantidadeDeCadastro1.Length){
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
        goto avançar4;
        }
        voltar:
        voltar1:
        voltar2:
        for(int B = 0; B < alterarCadastro1.Length; B++){
            Console.Write("Qual cadastro deseja alterar: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine();
        if(C >= quantidadeDeCadastro1.Length + 1){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar;
        }
        else if(C == 0){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar1;
        }
        else if(EX == 1){
        if(C - 1 >= quantidadeDeCadastro1.Length - excluirCadastro1.Length){
            Console.WriteLine("Cadastro não existente.");
            Console.WriteLine();
            goto voltar2;
        }}
            Console.Write("Digite o seu nome: ");
            nomeAl[C - 1] = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idadeAl[C - 1] = int.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            pesoAl[C - 1] = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            alturaAl[C - 1] = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu sexo: ");
            sexoAl[C - 1] = char.Parse(Console.ReadLine());
            Console.WriteLine("Cadastro de número ({0}) alterado.",N_deCadastros = C + 1);
            Console.WriteLine();
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        avançar4:
        Main();
    }
    static void Imprimirtodososcadastros(){
        N_deCadastros = 0;
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem imprimidos.");
            goto avançar;
        }
        else if(EX == 1){
        if(quantidadeDeCadastro1.Length - excluirCadastro1.Length == 0){
            Console.WriteLine("Não existem cadastros a serem imprimidos.");
            goto avançar1;
        }
        for(A = 0; A < quantidadeDeCadastro1.Length - excluirCadastro1.Length; A++){
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
        goto avançar1;
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
        avançar1:
        Console.ReadLine();
        Main();
    }
    static void Imprimirumcadastro(int Aa){
        N_deCadastros = 0;
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem imprimidos.");
            goto avançar;
        }
        else if(EX == 1){
        if(quantidadeDeCadastro1.Length - excluirCadastro1.Length == 0){
            Console.WriteLine("Não existem cadastros a serem imprimidos.");
            goto avançar1;
        }}
        else if(quantidadeDeCadastro1.Length == 1){
            int B = 0;
            Console.WriteLine("Cadastro de número ({0}):",N_deCadastros + 1);
            Console.WriteLine("Nome:{0}",nome[B]);
            Console.WriteLine("Idade:{0}",idade[B]);
            Console.WriteLine("Peso:{0}",peso[B]);
            Console.WriteLine("Altura:{0}",altura[B]);
            Console.WriteLine("Sexo:{0}",sexo[B]);
            Console.WriteLine();
            goto avançar2;
        }
        voltar:
        voltar1:
        voltar2:
        Console.Write("Qual cadastro deseja imprimir: ");
        Aa = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if(Aa >= quantidadeDeCadastro1.Length + 1){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar;
        }
        else if(Aa == 0){
            Console.WriteLine("(Erro do programa)");
            Console.WriteLine();
            goto voltar1;
        }
        else if(EX == 1){
        if(Aa - 1 >= quantidadeDeCadastro1.Length - excluirCadastro1.Length){
            Console.WriteLine("Cadastro não existente.");
            Console.WriteLine();
            goto voltar2;
        }}
        while(N_deCadastros < Aa){
            N_deCadastros++;
        }
        Console.WriteLine("Cadastro de número ({0}):",N_deCadastros);
        Console.WriteLine("Nome:{0}",nome[Aa - 1]);
        Console.WriteLine("Idade:{0}",idade[Aa - 1]);
        Console.WriteLine("Peso:{0}",peso[Aa - 1]);
        Console.WriteLine("Altura:{0}",altura[Aa - 1]);
        Console.WriteLine("Sexo:{0}",sexo[Aa - 1]);
        Console.WriteLine();
        avançar:
        avançar1:
        avançar2:
        Console.ReadLine();
        Main();
    }
    static void Excluircadastro(){
        if(A == 0){
            Console.WriteLine("Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar;
        }
        else if(EX == 1){
        if(quantidadeDeCadastro1.Length - excluirCadastro1.Length == 0){
            Console.WriteLine("Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar1;
        }}
        else if(EX == 1){
        if(quantidadeDeCadastro1.Length - excluirCadastro1.Length == 1){
            int Af = 0;
            nome[Af] = " ";
            idade[Af] = 0;
            peso[Af] = 0;
            altura[Af] = 0;
            sexo[Af] = ' ';
            Console.WriteLine("Cadastro excluido.");
            Console.WriteLine();
            goto ir;
        }}
        else if(quantidadeDeCadastro1.Length == 1){
            int Ag = 0;
            nome[Ag] = " ";
            idade[Ag] = 0;
            peso[Ag] = 0;
            altura[Ag] = 0;
            sexo[Ag] = ' ';
            Console.WriteLine("Cadastro excluido.");
            Console.WriteLine();
            goto ir1;
        }
        else if(EX == 1){
        if(quantidadeDeCadastro1.Length - excluirCadastro1.Length == 0){
            Console.WriteLine("Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar2;
        }}
        retorno:
        retorno1:
        Console.Write("Quantos cadastros deseja excluir: ");
        excluirCadastro = int.Parse(Console.ReadLine());
        excluirCadastro1 = new int[excluirCadastro1.Length + excluirCadastro];
        Console.WriteLine();
        if(excluirCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        if(excluirCadastro > quantidadeDeCadastro1.Length - excluirCadastro1.Length + excluirCadastro){
            Console.WriteLine("A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno1;
        }
        else if(excluirCadastro == 0){
        goto avançar3;
        }
        else if(excluirCadastro == quantidadeDeCadastro1.Length){
        for(int C = 0; C < excluirCadastro1.Length; C++){
            nome[C] = " ";
            idade[C] = 0;
            peso[C] = 0;
            altura[C] = 0;
            sexo[C] = ' ';
        }
            Console.WriteLine("Todos os cadastros foram excluidos.");
            Console.WriteLine();
            goto ir2;
        }
        else if(excluirCadastro == quantidadeDeCadastro1.Length - excluirCadastro1.Length + excluirCadastro){
        for(int D = 0; D < excluirCadastro1.Length; D++){
            nome[D] = " ";
            idade[D] = 0;
            peso[D] = 0;
            altura[D] = 0;
            sexo[D] = ' ';
        }
            Console.WriteLine("Todos os cadastros foram excluidos.");
            Console.WriteLine();
            goto ir3;
        }
        voltar:
        voltar1:
        voltar2:
        for(int B = 0; B < excluirCadastro; B++){
            Console.Write("Qual cadastro deseja excluir: ");
            int exCadastro = int.Parse(Console.ReadLine());
            Console.WriteLine();
        if(exCadastro >= quantidadeDeCadastro1.Length + 1){
            Console.WriteLine("(Erro do programa)");
            Console.ReadLine();
            goto voltar;
        }
        else if(exCadastro == 0){
            Console.WriteLine("(Erro do programa)");
            Console.ReadLine();
            goto voltar1;
        }
        else if(EX == 1){
        if(exCadastro - 1 > quantidadeDeCadastro1.Length + 1 - excluirCadastro1.Length){
            Console.WriteLine("(Erro do programa)");
            Console.ReadLine();
            goto voltar2;
        }}
        for(int Ba = exCadastro - 1; Ba < nome.Length - 1; Ba++){
            nome[Ba] = nome[Ba + 1];
        }
        for(int Bb = exCadastro - 1; Bb < idade.Length - 1; Bb++){
            idade[Bb] = idade[Bb + 1];
        }
        for(int Bc = exCadastro - 1; Bc < peso.Length - 1; Bc++){
            peso[Bc] = peso[Bc + 1];
        }
        for(int Bd = exCadastro - 1; Bd < altura.Length - 1; Bd++){
            altura[Bd] = altura[Bd + 1];
        }
        for(int Be = exCadastro - 1; Be < sexo.Length - 1; Be++){
            sexo[Be] = sexo[Be + 1];
        }
            nome[nome.Length - 1] = " ";
            idade[idade.Length - 1] = 0;
            peso[peso.Length - 1] = 0;
            altura[altura.Length - 1] = 0;
            sexo[sexo.Length - 1] = ' ';
            Console.WriteLine("Cadastro de número ({0}) excluido.",N_deCadastros = exCadastro);
            Console.WriteLine();
        }
        ir:
        ir1:
        ir2:
        ir3:
        EX = 1;
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