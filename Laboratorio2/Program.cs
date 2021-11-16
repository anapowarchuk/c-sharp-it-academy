// See https://aka.ms/new-console-template for more information
int [] array = new int [5] {10, 20, 30, 40,50};

for (int i = 0; i<5; i++) {
    Console.WriteLine("Indice = " + i + "& Valor = " + array [i]);
}

foreach (var x in array) {
    Console.WriteLine(x);
} 

Array.ForEach(array, Console.WriteLine);

string [] palavras = new string [3];
palavras[0] =  "C#";
palavras[1] = "é";
palavras[2] = "Legal";

int [,] matriz = new int[3,3];
matriz [0,0] = 1;
matriz [1,2] = 2;

bool[,,] cubo = new bool [3,3,3];

int[][] jagged = new int [3][];
jagged[0] = new int[3];

DateTime[] dt = new DateTime[2];
int iDate;
dt[0] = new DateTime(2002,5,1);
dt[1] = new DateTime(2002,6,1);
for (iDate = 0; iDate<2; iDate ++) {
    Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
}