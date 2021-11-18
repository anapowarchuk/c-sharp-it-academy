//Alocar, inicializar e acessar dados em uma Lista
List<string> listaStrings = new List<string>();
Console.WriteLine(listaStrings.Count);

listaStrings.Add("Alô");
listaStrings.Add("Mundo");
listaStrings.Add("!");

Console.WriteLine(listaStrings.Count);
Console.WriteLine(listaStrings[0]);

//listaStrings.Add(10);

listaStrings[0] = "Hola";

Console.WriteLine("------------------------------------");

var achei = listaStrings.Find(s => s.StartsWith("M")); //metodo anomimo que busca algo na lista
var listaImutavel = listaStrings.AsReadOnly(); //metodo que retorna uma lista de leitura
foreach (var item in listaImutavel)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------------------------");
//Alocar, inicializar e acessar dados em uma fila
Queue<Object> q  = new Queue<Object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());

Console.WriteLine("------------------------------------");
Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());


Console.WriteLine("------------------------------------");

//Manipulando dicionários genéricos
Dictionary<int,string> paises = new Dictionary<int,string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine($"O código 55 é {paises[55]}");
paises.Keys.ToList().ForEach(Console.WriteLine);
foreach (var item in paises)
{
    Console.WriteLine($"Código {item.Key} = {item.Value}");
}