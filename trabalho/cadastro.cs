using System;
class program{
    static int quantidadeDeCadastro;
    static int[] quantidadeDeCadastro1 = new int[0];
    static int excluirCadastro;
    static int[] excluirCadastro1;
    static string[] nome;
    static int[] idade;
    static double[] peso;
    static double[] altura;
    static char[] sexo;
    static int N_deCadastros;
    static int A;
    static int SA = 0;
    static void Main(){
        if(SA > 0){
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
        Console.WriteLine("\n Cadastrar________________________:(1)\n Alteração de cadastro____________:(2)\n Impreção de cadastros____________:(3)\n Excluir cadastro_________________:(4)\n Limpar a tela____________________:(5)\n Sair_____________________________:(6)");
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
            Impreçãodecadastro();
            break;
            case"4":
            Excluircadastro();
            break;
            case"5":
            Limparatela();
            break;
            case"6":
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
            Console.WriteLine(" Cadastros existentes <( {0} )>",quantidadeDeCadastro1.Length);
            Console.Write("\n Quantos cadastros deseja fazer: ");
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
                Console.WriteLine(" Cadastro de número <( {0} )>",N_deCadastros + 1);
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
                N_deCadastros++;
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
            Console.WriteLine(" Cadastro de número <( {0} )>",N_deCadastros + 1);
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
            A = 0;
            Console.Write(" Digite o seu nome: ");
            nomeAl[A] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idadeAl[A] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            pesoAl[A] = double.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            alturaAl[A] = double.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexoAl[A] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro alterado.");
            Console.WriteLine(" ===================");
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Cadastros existentes <( {0} )>",quantidadeDeCadastro1.Length);
        Console.Write("\n Quantos cadastros deseja alterar: ");
        int alterarCadastro = int.Parse(Console.ReadLine());
        int[] alterarCadastro1 = new int[alterarCadastro];
        int[] altCadastro = new int[alterarCadastro];
        Console.WriteLine();
        if(alterarCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem alterados não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(alterarCadastro == 0){
            goto avançar2;
        }
        else if(alterarCadastro1.Length == quantidadeDeCadastro1.Length){
            for(A = 0; A < alterarCadastro1.Length; A++){
                Console.Write(" Digite o seu nome: ");
                nomeAl[A] = Console.ReadLine();
                Console.Write(" Digite a sua idade: ");
                idadeAl[A] = int.Parse(Console.ReadLine());
                Console.Write(" Digite o seu peso: ");
                pesoAl[A] = double.Parse(Console.ReadLine());
                Console.Write(" Digite a sua altura: ");
                alturaAl[A] = double.Parse(Console.ReadLine());
                Console.Write(" Digite o seu sexo: ");
                sexoAl[A] = char.Parse(Console.ReadLine());
                Console.WriteLine(" Cadastro de número <( {0} )> alterado.",N_deCadastros = A);
                Console.WriteLine(" ===================================");
            }
        goto avançar3;
        }
        voltar:
        voltar1:
        Console.WriteLine(" Quais cadastros deseja alterar: ");
        for(A = 0; A < alterarCadastro1.Length; A++){
            altCadastro[A] = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(altCadastro[A] - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                Console.WriteLine();
                goto voltar;
            }
            else if(altCadastro[A] == 0){
                Console.WriteLine("\n (Erro do programa)");
                Console.WriteLine();
                goto voltar1;
            }
        }
        for(A = 0; A < alterarCadastro; A++){
            Console.Write(" Digite o seu nome: ");
            nomeAl[altCadastro[A] - 1] = Console.ReadLine();
            Console.Write(" Digite a sua idade: ");
            idadeAl[altCadastro[A] - 1] = int.Parse(Console.ReadLine());
            Console.Write(" Digite o seu peso: ");
            pesoAl[altCadastro[A] - 1] = double.Parse(Console.ReadLine());
            Console.Write(" Digite a sua altura: ");
            alturaAl[altCadastro[A] - 1] = double.Parse(Console.ReadLine());
            Console.Write(" Digite o seu sexo: ");
            sexoAl[altCadastro[A] - 1] = char.Parse(Console.ReadLine());
            Console.WriteLine(" Cadastro de número <( {0} )> alterado.",N_deCadastros = altCadastro[A]);
            Console.WriteLine(" =====================================");
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Impreçãodecadastro(){
        Console.WriteLine("<===========================>\n<=| Impreção de cadastros |=>\n<===========================>");
        Console.WriteLine();
        N_deCadastros = 0;
        if(quantidadeDeCadastro1.Length == 0){
            Console.WriteLine(" Não existem cadastros a serem imprimidos.");
            goto avançar;
        }
        else if(quantidadeDeCadastro1.Length == 1){
            A = 0;
            Console.WriteLine(" Cadastro de número <( {0} )>:",N_deCadastros + 1);
            Console.WriteLine(" Nome:{0}",nome[A]);
            Console.WriteLine(" Idade:{0}",idade[A]);
            Console.WriteLine(" Peso:{0}",peso[A]);
            Console.WriteLine(" Altura:{0}",altura[A]);
            Console.WriteLine(" Sexo:{0}",sexo[A]);
            Console.WriteLine(" ============================");
            Console.WriteLine();
            goto avançar1;
        }
        retorno:
        Console.WriteLine(" Cadastros existentes <( {0} )>",quantidadeDeCadastro1.Length);
        Console.Write("\n Quantos cadastros deseja imprimir: ");
        int imprimirCadastro = int.Parse(Console.ReadLine());
        int[] imprimirCadastro1 = new int[imprimirCadastro];
        int[] impCadastro = new int[imprimirCadastro];
        Console.WriteLine();
        if(imprimirCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem imprimidos não corresponde a quantidade de cadastros existentes.");
            goto retorno;
        }
        else if(imprimirCadastro == 0){
            goto avançar2;
        }
        else if(imprimirCadastro == quantidadeDeCadastro1.Length){
            for(A = 0; A < quantidadeDeCadastro1.Length; A++){
                N_deCadastros++;
                Console.WriteLine(" Cadastro de número <( {0} )>:",N_deCadastros);
                Console.WriteLine(" Nome:{0}",nome[A]);
                Console.WriteLine(" Idade:{0}",idade[A]);
                Console.WriteLine(" Peso:{0}",peso[A]);
                Console.WriteLine(" Altura:{0}",altura[A]);
                Console.WriteLine(" Sexo:{0}",sexo[A]);
                Console.WriteLine(" ============================");
            }
            goto avançar3;
        }
        voltar:
        voltar1:
        Console.WriteLine(" Quais cadastros deseja imprimir: ");
        for(A = 0; A < imprimirCadastro; A++){
        impCadastro[A] = int.Parse(Console.ReadLine());
        Console.WriteLine();
            if(impCadastro[A] - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                Console.WriteLine();
                goto voltar;
            }
            else if(impCadastro[A] == 0){
                Console.WriteLine("\n (Erro do programa)");
                Console.WriteLine();
                goto voltar1;
            }
        }
        for(A = 0; A < imprimirCadastro; A++){
            Console.WriteLine(" Cadastro de número <( {0} )>:",N_deCadastros = impCadastro[A]);
            Console.WriteLine(" Nome:{0}",nome[impCadastro[A] - 1]);
            Console.WriteLine(" Idade:{0}",idade[impCadastro[A] - 1]);
            Console.WriteLine(" Peso:{0}",peso[impCadastro[A] - 1]);
            Console.WriteLine(" Altura:{0}",altura[impCadastro[A] - 1]);
            Console.WriteLine(" Sexo:{0}",sexo[impCadastro[A] - 1]);
            Console.WriteLine(" ============================");
            Console.WriteLine();
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Console.ReadLine();
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
            A = 0;
            nome[A] = " ";
            idade[A] = 0;
            peso[A] = 0.0;
            altura[A] = 0.0;
            sexo[A] = ' ';
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
        Console.WriteLine(" Cadastros existentes <( {0} )>",quantidadeDeCadastro1.Length);
        Console.Write("\n Quantos cadastros deseja excluir: ");
        excluirCadastro = int.Parse(Console.ReadLine());
        excluirCadastro1 = new int[excluirCadastro1.Length + excluirCadastro];
        int[] excCadastro = new int[excluirCadastro];
        if(excluirCadastro > quantidadeDeCadastro1.Length){
            Console.WriteLine("\n A quantidade de cadastros a serem excluidos não corresponde a quantidade de cadastros existentes.");
            Console.WriteLine();
            goto retorno;
        }
        else if(excluirCadastro == 0){
            goto avançar2;
        }
        else if(excluirCadastro == quantidadeDeCadastro1.Length){
            for(A = 0; A < excluirCadastro1.Length; A++){
                nome[A] = " ";
                idade[A] = 0;
                peso[A] = 0.0;
                altura[A] = 0.0;
                sexo[A] = ' ';
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
        Console.WriteLine(" Quais cadastros deseja excluir:");
        for(A = 0; A < excluirCadastro; A++){
            excCadastro[A] = int.Parse(Console.ReadLine());
            Console.WriteLine(" ================================");
            if(excCadastro[A] - 1 >= quantidadeDeCadastro1.Length){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar;
            }
            else if(excCadastro[A] == 0){
                Console.WriteLine("\n (Erro do programa)");
                goto voltar1;
            }
        }
        Array.Sort(excCadastro);
        Array.Reverse(excCadastro);
        for(A = 0; A < excluirCadastro; A++){
            for(int Aa = excCadastro[A] - 1; Aa < quantidadeDeCadastro1.Length - 1; Aa++){
                nome[Aa] = nome[Aa + 1];
                idade[Aa] = idade[Aa + 1];
                peso[Aa] = peso[Aa + 1];
                altura[Aa] = altura[Aa + 1];
                sexo[Aa] = sexo[Aa + 1];
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
        Array.Sort(excCadastro);
        for(A = 0; A < excluirCadastro; A++){
            Console.WriteLine("\n Cadastro de número <( {0} )> excluido.",N_deCadastros = excCadastro[A]);
            Console.WriteLine();
        }
        avançar:
        avançar1:
        avançar2:
        avançar3:
        Main();
    }
    static void Limparatela(){
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