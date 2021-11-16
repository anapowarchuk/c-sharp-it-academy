using System.Text;


//Trabalhando com tipos-valor fundamentais byte, int e long

byte b;
b = byte.MaxValue;
Console.WriteLine("Valor máximo de byte:");
Console.WriteLine(b);
Console.WriteLine($"Valor máximo de byte: {b}");

int i;
i = int.MaxValue;
Console.WriteLine("Valor máximo de byte: " + i);


//Trabalhando com strings
string strPrimeira = "Alô ";
string strSegunda = "Mundo!";
string strTerceira = strPrimeira + strSegunda;
int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString();

Console.WriteLine(strTerceira);
Console.WriteLine(strTerceira.Length);
Console.WriteLine(strQuarta);
Console.WriteLine(strTerceira.Substring(0, 5));
Console.WriteLine(strPrimeira[0]);


//Trabalhando com objetos do Framework
DateTime dt = new DateTime(2021, 11, 10);
Console.WriteLine(dt);
Console.WriteLine(dt.ToShortDateString());
Console.WriteLine($"Hoje é {dt:dd-MM-yyyy}");


//outros
int x = 0;
int y = x;
x++;
Console.WriteLine(x);
Console.WriteLine(y);


StringBuilder s = new StringBuilder();
Console.WriteLine(s);
StringBuilder t = s;
s.Append("Alô");
Console.WriteLine(s);
Console.WriteLine(t);