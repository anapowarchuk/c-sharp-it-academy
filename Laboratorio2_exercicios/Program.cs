/*
1. Faça um programa que crie dois arrays de tamanhos iguais de números inteiros. Popule um dos arrays
com diversos valores e deixe o outro array vazio. Agora, realize a cópia dos elementos do primeiro array
para o segundo
*/

int [] array1 = new int [10];
int [] array2 = new int[10];
int i = 0;


Random randNum = new Random();


foreach (var x in array1) {
   x = randNum.Next();
} 

 Console.WriteLine("ARRAY 1");
foreach (var x in array1) {
    Console.Write("| "+ x + " |");
} 


foreach (var x in array1) {
    array2[i] = x;
    i++;
} 

 Console.WriteLine("ARRAY 2");
foreach (var x in array2) {
    Console.Write("| "+ x + " |");
} 

/*
2. Escreve um programa que crie uma matriz de valores inteiros (5x5) e retorne o valor da soma
de cada coluna. Apresente duas versões para o programa: multidimensional e array jagged
*/

int [,] matriz = new int[5,5];
Random randNum = new Random();

for (int i = 0 ; i<5; i++) {
    for (int j = 0 ; j<5; i++) {
        matriz[i, j] = randNum.Next();
    }
}

int soma = 0;
for (int j = 0 ; j<5; j++) {
    for (int i = 0 ; i<5; i++) {
        soma += matriz[i,j];
    }
}
Console.Write(soma);
