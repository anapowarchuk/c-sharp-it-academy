using System;

class Program{

    static void Main (string[] args) {

        Console.WriteLine("QUESTÃO 1");
        questao1();
        Console.WriteLine("\nQUESTÃO 2");
        questao2();        
        Console.WriteLine("\nQUESTÃO 3");
        questao3();

        //string texto;
        // i=0;
        /*while (texto !="4")
        {
            Console.WriteLine("Qual a opção que você deseja? \n");
            texto = Console.ReadLine();
            if (texto == "1"){
                questao1();
            }
            else if (texto == "2"){
                questao2();
            }
            else if (texto == "3"){
                questao3();
            }
        }*/
    
    }



    //1. Como fazer para recuperar o código DDI a partir do nome de um país no exemplo de uso do Dicionário?
    private static void questao1() {
        Dictionary<int,string> paises = new Dictionary<int,string>();
        paises[33] = "França";
        paises[44] = "Reino Unido";
        paises[55] = "Brasil";
        Console.WriteLine($"O código 55 é {paises[55]}");
        paises.Keys.ToList().ForEach(Console.WriteLine); //transforma em uma lista e imprime em cada elemento uma das chaves
        foreach (var item in paises){
            Console.WriteLine($"Código {item.Key} = {item.Value}"); //cada item do dicionario imprime a chav3e do dicionario
        }
    }
    
/*
2. Dada uma lista de números reais, implemente um método TotalAcimaMedia, para calcular e retornar o
número de elementos da lista cujos valores são maiores do que a média de todos os elementos.
*/
   private static void questao2() {
        List<int> valores = new List<int>();
        int[] numeros = new int[] {16, 18, 23, 12};
        valores.AddRange(numeros);

        float p = TotalAcimaMedia(valores);
        Console.WriteLine($"Há {p} maiores que a média");
        
    }

    private static float TotalAcimaMedia(List<int> valores) {
        int soma =0, cont=0;
        foreach (int item in valores){
            soma += item;
        }
        float media = soma/ (valores.Count);
        
        foreach (int item in valores){
            if (item>media){
                cont++;
            }
        }
        return cont;
    }


    /*
    3. Você consegue imaginar uma forma de retornar uma nova lista com esses valores, ao invés de apenas
    retornar o número de elementos? Crie o método ListaAcimaMedia.
    */

    private static void questao3() {
        List<int> valores = new List<int>();
        int[] numeros = new int[] {16, 18, 23, 12};
        valores.AddRange(numeros);

        List <int> p = ListaAcimaMedia(valores);
        Console.WriteLine($"Valores acimas da Média:");
        foreach (var item in p) {
            Console.WriteLine(item);
        }
    }


    private static List<int> ListaAcimaMedia(List<int> valores) {
        List<int> novaLista = new List<int>();
        int soma =0;
        foreach (int item in valores){
            soma += item;
        }
        float media = soma/ (valores.Count);
        
        foreach (int item in valores){
            if (item>media){
                novaLista.Add(item);
            }
        }
        return novaLista;
    }
}