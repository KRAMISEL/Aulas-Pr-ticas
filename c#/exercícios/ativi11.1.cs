using System;
using System.Collections.Generic;
class cadastros{
    static void Main(){
        Eventos eventos = new Eventos();
        eventos.cadastrosEventos();
        Console.WriteLine("   Evento   |   Local   |   Valor do evento    |");
        for(int i = 0; i < eventos.quantiEventos; i++){
            Console.WriteLine(" {0} | {1} | {2:c} |",eventos.nomeEvento[i], eventos.localEvento[i], eventos.valorEvento[i]);
            Console.WriteLine(" Nome | Endereço | Idade |");
            for(int ia = 0; ia < eventos.pessoasPE[i]; ia++){
                Console.WriteLine(" {0} | {1} | {2} |",eventos.nomes[i,ia], eventos.endereços[i,ia], eventos.idades[i,ia]);
            }
        }
    }
}
public class Eventos{
    public List<string> nomeEvento = new List<string>();
    public List<string> localEvento = new List<string>();
    public List<bool> pagamento = new List<bool>();
    public List<float> valorEvento = new List<float>();
    public List<int> pessoasPE = new List<int>();
    public string[,] nomes;
    public int[,] endereços;
    public int[,] idades;
    public int quantiEventos;
    public void cadastrosEventos(){
        Console.WriteLine("Quantos eventos serão registrados.");
        quantiEventos = int.Parse(Console.ReadLine());
        for(int i = 0; i < quantiEventos; i++){
            Console.WriteLine(". : Evento {0} : .",i + 1);
            Console.WriteLine("Qual será o nome do evento.");
            nomeEvento.Add(Console.ReadLine());
            Console.WriteLine("Qual será o local do evento.");
            localEvento.Add(Console.ReadLine());
            Console.WriteLine("O evento será a pago.\n[s/n]");
            char pag = char.Parse(Console.ReadLine());
            if(pag == 's'){
                Console.WriteLine("qual o valor do evento.");
                pagamento.Add(true);
                valorEvento.Add(int.Parse(Console.ReadLine()));
            }
            else{
                pagamento.Add(false);
                valorEvento.Add(0);
            }
        }
        nomes = new string[quantiEventos, 20];
        endereços = new int[quantiEventos, 20];
        idades = new int[quantiEventos, 20];
        voltar:
        for(int i = 0; i < quantiEventos; i++){
            Console.WriteLine("Quantos pessoas serão registradas no evento.\nO máximo de pessoas por evento é 20.");
            int quantiPessoas = int.Parse(Console.ReadLine());
            if(quantiPessoas > 20){
                Console.WriteLine("O máximo de pessoas por evento é 20.");
                goto voltar;
            }
            pessoasPE.Add(quantiPessoas);
            for(int ia = 0; ia < quantiPessoas; ia++){
                Console.WriteLine(". : Pessoa {0} : .",ia + 1);
                Console.WriteLine("Digite o nome da pessoa:");
                nomes[i,ia] = Console.ReadLine();
                Console.WriteLine("Digite o endereço da pessoa:");
                endereços[i,ia] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a idade da pessoa:");
                idades[i,ia] = int.Parse(Console.ReadLine());
            }
        }
    }
}