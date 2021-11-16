
/*
1. Além de tipos inteiros, C# também suporta float, double, e decimal o qual garante uma boa precisão para
trabalhos com valores monetários. Escreva algum código para testar variáveis destes novos tipos e mostrar o
resultado na tela do console.
*/
Console.WriteLine ("----------- Questão 1 -----------");
float a;
a = 1;
Console.WriteLine (a);

double b = 1.3;
Console.WriteLine (b);

//decimal c = 1.5;

/*
4. Converter dados em C# se dá de forma implícita ou explícita. Digite o seguinte exemplo e note que a
conversão para um tipo “maior” é feita de forma implícita e, para um tipo “menor” de forma explícita. 
*/
int i = 10;
float f = 0;
f = i; //conversão implícita, sem perda de dados.
System.Console.WriteLine(f);
f = 0.5F;
i = (int) f; //conversão explícita, com perda de dados.
System.Console.WriteLine(i);


/*
5. Além das conversões realizadas pela linguagem C#, podemos utilizar um mecanismo fornecido pelo
próprio Framework, que é independente da linguagem utilizada. Este mecanismo é a classe System.Convert.
Escreva um programa para testar os diferentes métodos de conversão. Como exemplo, utilize as seguintes
linhas de comandos:
*/

string stringInteiro = "123456789";
int valorStringInteiro = Convert.ToInt32(stringInteiro);
Console.WriteLine(valorStringInteiro);
Int64 valorInt64 = 123456789;
int valorInt = Convert.ToInt32(valorInt64);
Console.WriteLine(valorInt);

string stringInteiroGrande = "999999999999999999999999999999999999999999999";
int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);


/*
6.Escreva um programa para testar o método TryParse. Como exemplo, utilize as seguintes linhas de
comandos:
*/

string stringInteiro1 = "123456789";
int valorStringInteiro1;
bool conversao1 = Int32.TryParse(stringInteiro1, out valorStringInteiro1);
Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro1);
string stringInteiroGrande1 = "999999999999999999999999999999999999999999999";
int valorStringInteiroGrande1;
bool conversao2 = Int32.TryParse(stringInteiroGrande1, out valorStringInteiroGrande1);
Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " +
valorStringInteiroGrande1);
string stringLetras = "abc";
double valorStringLetras;
bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);


/*
7. Devemos ter muito cuidado com os métodos de conversão de valores, pois arredondamentos são
executados de formas diferentes. Verifique o comportamento do seguinte trecho de código.
*/

double valorFracionado = 4.7;
int valorInteiro1 = (int) valorFracionado;
int valorInteiro2 = Convert.ToInt32(valorFracionado);
Console.WriteLine("Conversao explicita = " + valorInteiro1);
Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

/*
8. O comando de saída em console tem uma sintaxe específica para a exibição de valores de várias variáveis.
Teste o trecho abaixo. Explique como o mesmo funciona.
*/
int x = 10;
double y = 3.4;
Console.WriteLine("{0} {1}",x,y);