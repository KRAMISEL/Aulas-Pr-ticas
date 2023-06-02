using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1 = new int[0];
    static int excluirCadastro;
    static int[] excluirCadastro1 = new int[0];
    static string[] nome;
    static int[] idade;
    static double[] peso;
    static double[] altura;
    static char[] sexo;
    static int N_deCadastros;
    static int A;
    static int LT = 0;
    static int SA = 0;
    static void Main(){
        if(LT > 0){
            Console.Clear();
        }
        else if(SA > 0){
            Console.Clear();
            goto avançar;
        }
        Console.WriteLine("<========================================>\n<=| Atendimento de cadastro ao cliente |=>\n<========================================>");
        Console.WriteLine("\n O que deseja fazer:");
        Menu();
        avançar:
        Console.Write(" ");
    }
    static void Menu(){
        Console.WriteLine("\n Cadastrar________________________:(1)\n Alteração de cadastro____________:(2)\n Impreção de todos os cadastros___:(3)\n Impreção de um cadastro__________:(4)\n Excluir cadastro_________________:(5)\n Trocar ordem de cadastro_________:(6)\n Limpar a tela____________________:(7)\n Sair_____________________________:(8)");
        string execução = Console.ReadLine();
        Console.WriteLine();
        switch(execução){
            case"1":
            Cadastrar();
            break;
            case"2":
            Alteraçãodecadastro(ref nome,ref idade,ref peso,ref altura,ref sexo);
            break;
            case"3":
            Impreçãodetodososcadastros();
            break;
            case"4":
            Impreçãodeumcadastro(A);
            break;
            case"5":
            Excluircadastro();
            break;
            case"6":
            Trocardeordem();
            break;
            case"7":
            Limparatela();
            break;
            case"8":
            Sair();
            break;
            default:
            Main();
            break;
        }
    }
    static void Cadastrar(){
        Console.WriteLine("<===============>\n<=| Cadastrar |=>\n<===============>");
        Console.WriteLine();
        if(quantidadeDeCadastro > 0){
            string[] armazenamentoDeNomes = new string[nome.Length];
            int[] armazenamentoDeIdades = new int[idade.Length];
            double[] armazenamentoDePesos = new double[peso.Length];
            double[] armazenamentoDeAlturas = new double[altura.Length];
            char[] armazenamentoDeSexos = new char[sexo.Length];
            for(A = 0; A < quantidadeDeCadastro1.Length; A++){
                armazenamentoDeNomes[A] = nome[A];
                armazenamentoDeIdades[A] = idade[A];
                armazenamentoDePesos[A] = peso[A];
                armazenamentoDeAlturas[A] = altura[A];
                armazenamentoDeSexos[A] = sexo[A];
            }
            Console.Write(" Quantos cadastros deseja fazer: ");
            int quantidadeDeCadastro2 = int.Parse(Console.ReadLine());
            if(quantidadeDeCadastro2 == 0){
                goto avançar;
            }
            quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length + quantidadeDeCadastro2];
            nome = new string[nome.Length + quantidadeDeCadastro2];
            idade = new int[idade.Length + quantidadeDeCadastro2];
            peso = new double[peso.Length + quantidadeDeCadastro2];
            altura = new double[altura.Length + quantidadeDeCadastro2];
            sexo = new char[sexo.Length + quantidadeDeCadastro2];
            for(A = 0; A < quantidadeDeCadastro1.Length - quantidadeDeCadastro2; A++){
                nome[A] = armazenamentoDeNomes[A];
                idade[A] = armazenamentoDeIdades[A];
                peso[A] = armazenamentoDePesos[A];
                altura[A] = armazenamentoDeAlturas[A];
                sexo[A] = armazenamentoDeSexos[A];
            }
            for(A = 0; A < quantidadeDeCadastro2; A++){
                N_deCadastros++;
                Console.WriteLine(" Cadastro de número <({0})>",N_deCadastros + 1);
                Console.Write(" Digite o seu nome: ");
                nome[A + nome.Length - quantidadeDeCadastro2] = Console.ReadLine();
                Console.Write(" Digite a sua idade: ");
                idade[A + idade.Length - quantidadeDeCadastro2] = int.Parse(Console.ReadLine());
                Console.Write(" Digite o seu peso: ");
                peso[A + peso.Length - quantidadeDeCadastro2] = double.Parse(Console.ReadLine());
                Console.Write(" Digite a sua altura: ");
                altura[A + altura.Length - quantidadeDeCadastro2] = double.Parse(Console.ReadLine());
                Console.Write(" Digite o seu sexo: ");
                sexo[A + sexo.Length - quantidadeDeCadastro2] = char.Parse(Console.ReadLine());
                Console.WriteLine(" ==================================");
            }
            goto avançar1;
        }
        N_deCadastros = 0;
        Console.Write(" Quantos cadastros deseja fazer: ");
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
            Console.WriteLine(" Cadastro de número <({0})>",N_deCadastros + 1);
            Console.Write(" Digite o seu nome: ");
            nome[A] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idade[A] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            peso[A] = double.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            altura[A] = double.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexo[A] = char.Parse(Console.ReadLine());
            Console.WriteLine(" ==================================");
            N_deCadastros++;
        }
        avançar:
        avançar1:
        avançar2:
        LT = 0;
        SA = 0;
        Main();
    }
    static void Alteraçãodecadastro(ref string[] nomeAl,ref int[] idadeAl,ref double[] pesoAl,ref double[] alturaAl,ref char[] sexoAl){
        Console.WriteLine("<===========================>\n<=| Alteração de cadastro |=>\n<===========================>");
        Console.WriteLine();
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem alterados.");
            Console.ReadLine();
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            int Aa = 0;
            Console.Write(" Digite o seu nome: ");
            nomeAl[Aa] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idadeAl[Aa] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            pesoAl[Aa] = double.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            alturaAl[Aa] = double.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexoAl[Aa] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro alterado.");
            Console.WriteLine(" ===================");
            goto avançar1;
        }
        retorno:
        Console.Write(" Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] alterarCadastro1 = new int[alterarCadastro];
        Console.WriteLine();
        if(alterarCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(alterarCadastro == 0){
            goto avançar2;
        }
        else if(alterarCadastro1.Length == quantidadeDeCadastro1.Length){
            for(int D = 0; D < alterarCadastro1.Length; D++){
                Console.Write(" Digite o seu nome: ");
                nomeAl[D] = Console.ReadLine();
                Console.Write(" Digite a sua idade: ");
                idadeAl[D] = int.Parse(Console.ReadLine());
                Console.Write(" Digite o seu peso: ");
                pesoAl[D] = double.Parse(Console.ReadLine());
                Console.Write(" Digite a sua altura: ");
                alturaAl[D] = double.Parse(Console.ReadLine());
                Console.Write(" Digite o seu sexo: ");
                sexoAl[D] = char.Parse(Console.ReadLine());
                Console.WriteLine(" Cadastro de número <({0})> alterado.",N_deCadastros = D);
                Console.WriteLine(" ===================================");
            }
        goto avançar3;
        }
        voltar:
        voltar1:
        for(int B = 0; B < alterarCadastro1.Length; B++){
            Console.Write(" Qual cadastro deseja alterar: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(C - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                Console.WriteLine();
                goto voltar;
            }
            else if(C == 0){
                Console.WriteLine("\n (Erro do programa)");
                Console.WriteLine();
                goto voltar1;
            }
            Console.Write(" Digite o seu nome: ");
            nomeAl[C - 1] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idadeAl[C - 1] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            pesoAl[C - 1] = double.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            alturaAl[C - 1] = double.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexoAl[C - 1] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro de número <({0})> alterado.",N_deCadastros = C);
            Console.WriteLine(" =====================================");
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        LT = 0;
        SA = 0;
        Main();
    }
    static void Impreçãodetodososcadastros(){
        Console.WriteLine("<====================================>\n<=| Impreção de todos os cadastros |=>\n<====================================>");
        Console.WriteLine();
        N_deCadastros = 0;
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem imprimidos.");
            goto avançar;
        }
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
            if(N_deCadastros < A){
                N_deCadastros++;
            }
            Console.WriteLine(" Cadastro de número <({0})>:",N_deCadastros + 1);
            Console.WriteLine(" Nome:{0}",nome[A]);
            Console.WriteLine(" Idade:{0}",idade[A]);
            Console.WriteLine(" Peso:{0}",peso[A]);
            Console.WriteLine(" Altura:{0}",altura[A]);
            Console.WriteLine(" Sexo:{0}",sexo[A]);
            Console.WriteLine(" ============================");
        }
        avançar:
        Console.ReadLine();
        LT = 0;
        SA = 0;
        Main();
    }
    static void Impreçãodeumcadastro(int Aa){
        Console.WriteLine("<=============================>\n<=| Impreção de um cadastro |=>\n<=============================>");
        Console.WriteLine();
        N_deCadastros = 0;
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem imprimidos.");
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            int B = 0;
            Console.WriteLine(" Cadastro de número <({0})>:",N_deCadastros + 1);
            Console.WriteLine(" Nome:{0}",nome[B]);
            Console.WriteLine(" Idade:{0}",idade[B]);
            Console.WriteLine(" Peso:{0}",peso[B]);
            Console.WriteLine(" Altura:{0}",altura[B]);
            Console.WriteLine(" Sexo:{0}",sexo[B]);
            Console.WriteLine(" ============================");
            Console.WriteLine();
            goto avançar1;
        }
        voltar:
        voltar1:
        Console.Write(" Qual cadastro deseja imprimir: ");
        Aa = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if(Aa - 1 >= quantidadeDeCadastro1.Length){
            Console.WriteLine("\n (Erro do programa)");
            Console.WriteLine();
            goto voltar;
        }
        else if(Aa == 0){
            Console.WriteLine("\n (Erro do programa)");
            Console.WriteLine();
            goto voltar1;
        }
        while(N_deCadastros < Aa){
            N_deCadastros++;
        }
        Console.WriteLine(" Cadastro de número <({0})>:",N_deCadastros);
        Console.WriteLine(" Nome:{0}",nome[Aa - 1]);
        Console.WriteLine(" Idade:{0}",idade[Aa - 1]);
        Console.WriteLine(" Peso:{0}",peso[Aa - 1]);
        Console.WriteLine(" Altura:{0}",altura[Aa - 1]);
        Console.WriteLine(" Sexo:{0}",sexo[Aa - 1]);
        Console.WriteLine(" ============================");
        Console.WriteLine();
        avançar:
        avançar1:
        Console.ReadLine();
        LT = 0;
        SA = 0;
        Main();
    }
    static void Excluircadastro(){
        Console.WriteLine("<======================>\n<=| Excluir cadastro |=>\n<======================>");
        Console.WriteLine();
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem excluidos.");
            Console.ReadLine();
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            int Af = 0;
            nome[Af] = " ";
            idade[Af] = 0;
            peso[Af] = 0;
            altura[Af] = 0;
            sexo[Af] = ' ';
            excluirCadastro1 = new int[excluirCadastro1.Length + 1];
            quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - excluirCadastro];
            nome = new string[nome.Length - excluirCadastro];
            idade = new int[idade.Length - excluirCadastro];
            peso = new double[peso.Length - excluirCadastro];
            altura = new double[altura.Length - excluirCadastro];
            sexo = new char[sexo.Length - excluirCadastro];
            N_deCadastros = 0;
            Console.WriteLine(" Cadastro excluido.");
            Console.WriteLine();
            goto avançar1;
        }
        retorno:
        Console.Write(" Quantos cadastros deseja excluir: ");
        excluirCadastro = int.Parse(Console.ReadLine());
        excluirCadastro1 = new int[excluirCadastro1.Length + excluirCadastro];
        int[] exCadastro = new int[excluirCadastro];
        if(excluirCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        else if(excluirCadastro == 0){
            goto avançar2;
        }
        else if(excluirCadastro == quantidadeDeCadastro1.Length){
            for(int C = 0; C < excluirCadastro1.Length; C++){
                nome[C] = " ";
                idade[C] = 0;
                peso[C] = 0;
                altura[C] = 0;
                sexo[C] = ' ';
            }
            quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - excluirCadastro];
            nome = new string[nome.Length - excluirCadastro];
            idade = new int[idade.Length - excluirCadastro];
            peso = new double[peso.Length - excluirCadastro];
            altura = new double[altura.Length - excluirCadastro];
            sexo = new char[sexo.Length - excluirCadastro];
            N_deCadastros = 0;
            Console.WriteLine("\n Todos os cadastros foram excluidos.");
            Console.WriteLine();
            goto avançar3;
        }
        voltar:
        voltar1:
        Console.WriteLine("\n Quais cadastros deseja excluir:");
        for(A = 0; A < excluirCadastro; A++){
            exCadastro[A] = int.Parse(Console.ReadLine());
            Console.WriteLine(" ================================");
            if(exCadastro[A] >= quantidadeDeCadastro1.Length + 1){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar;
            }
            else if(exCadastro[A] == 0){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar1;
            }
        }
        Array.Sort(exCadastro);
        Array.Reverse(exCadastro);
        for(A = 0; A < excluirCadastro; A++){
            for(int Ba = exCadastro[A] - 1; Ba < nome.Length - 1; Ba++){
                nome[Ba] = nome[Ba + 1];
            }
            for(int Bb = exCadastro[A] - 1; Bb < idade.Length - 1; Bb++){
                idade[Bb] = idade[Bb + 1];
            }
            for(int Bc = exCadastro[A] - 1; Bc < peso.Length - 1; Bc++){
                peso[Bc] = peso[Bc + 1];
            }
            for(int Bd = exCadastro[A] - 1; Bd < altura.Length - 1; Bd++){
                altura[Bd] = altura[Bd + 1];
            }
            for(int Be = exCadastro[A] - 1; Be < sexo.Length - 1; Be++){
                sexo[Be] = sexo[Be + 1];
            }
        }
        string[] armazenamentoDeNomes = new string[nome.Length - excluirCadastro];
        int[] armazenamentoDeIdades = new int[idade.Length - excluirCadastro];
        double[] armazenamentoDePesos = new double[peso.Length - excluirCadastro];
        double[] armazenamentoDeAlturas = new double[altura.Length - excluirCadastro];
        char[] armazenamentoDeSexos = new char[sexo.Length - excluirCadastro];
        for(A = 0; A < quantidadeDeCadastro1.Length - excluirCadastro; A++){
            armazenamentoDeNomes[A] = nome[A];
            armazenamentoDeIdades[A] = idade[A];
            armazenamentoDePesos[A] = peso[A];
            armazenamentoDeAlturas[A] = altura[A];
            armazenamentoDeSexos[A] = sexo[A];
        }
        quantidadeDeCadastro1 = new int[quantidadeDeCadastro1.Length - excluirCadastro];
        nome = new string[nome.Length - excluirCadastro];
        idade = new int[idade.Length - excluirCadastro];
        peso = new double[peso.Length - excluirCadastro];
        altura = new double[altura.Length - excluirCadastro];
        sexo = new char[sexo.Length - excluirCadastro];
        for(A = 0; A < quantidadeDeCadastro1.Length; A++){
            nome[A] = armazenamentoDeNomes[A];
            idade[A] = armazenamentoDeIdades[A];
            peso[A] = armazenamentoDePesos[A];
            altura[A] = armazenamentoDeAlturas[A];
            sexo[A] = armazenamentoDeSexos[A];
        }
        Array.Sort(exCadastro);
        for(A = 0; A < excluirCadastro; A++){
            Console.WriteLine("\n Cadastro de número <({0})> excluido.",N_deCadastros = exCadastro[A]);
            Console.WriteLine();
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        LT = 0;
        SA = 0;
        Main();
    }
    static void Trocardeordem(){
        Console.WriteLine("<==============================>\n<=| Trocar ordem de cadastro |=>\n<==============================>");
        Console.WriteLine();
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem trocados.");
            Console.ReadLine();
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            Console.WriteLine(" não existem cadastros suficientes para serem trocados.");
            Console.ReadLine();
            goto avançar1;
        }
        else if(quantidadeDeCadastro1.Length == 2){
            goto avançar2;
        }
        int[] trocarCadastro = new int[2];
        voltar:
        voltar1:
        Console.WriteLine(" Quais cadastros deseja trocar de ordem:");
        for(A = 0; A < trocarCadastro.Length; A++){
            trocarCadastro[A] = int.Parse(Console.ReadLine());
            if(trocarCadastro[A] >= quantidadeDeCadastro1.Length + 1){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar;
            }
            else if(trocarCadastro[A] == 0){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar1;
            }
        }
        for(A = 0; A < 1; A++){
            nome[trocarCadastro[A] - 1] = nome[trocarCadastro[A + 1] - 1];
            idade[trocarCadastro[A] - 1] = idade[trocarCadastro[A + 1] - 1];
            peso[trocarCadastro[A] - 1] = peso[trocarCadastro[A + 1] - 1];
            altura[trocarCadastro[A] - 1] = altura[trocarCadastro[A + 1] - 1];
            sexo[trocarCadastro[A] - 1] = sexo[trocarCadastro[A + 1] - 1];
            nome[trocarCadastro[A + 1] - 1] = nome[trocarCadastro[A] - 1];
            idade[trocarCadastro[A + 1] - 1] = idade[trocarCadastro[A] - 1];
            peso[trocarCadastro[A + 1] - 1] = peso[trocarCadastro[A] - 1];
            altura[trocarCadastro[A + 1] - 1] = altura[trocarCadastro[A] - 1];
            sexo[trocarCadastro[A + 1] - 1] = sexo[trocarCadastro[A] - 1];
            Console.WriteLine(" Cadastros <({0})> e <({1})> trocados.",trocarCadastro[A],trocarCadastro[A + 1]);
        }
        avançar:
        avançar1:
        avançar2:
        LT = 0;
        SA = 0;
        Main();
    }
    static void Limparatela(){
        LT = 1;
        Console.Clear();
        Main();
    }
    static void Sair(){
        Console.Clear();
        Console.WriteLine(" Volte sempre. ;)");
        Console.Write(" ");
        SA = 1;
    }   
}