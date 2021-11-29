/*var fullNames = new [] {"Anne Williams", "John Fred Smith", "Sue Green"}.AsQueryable();

// para cada nome da string - quebra em espaços em branco ? - colecao de arrays de strings
IEnumrable<string[]> query1 = fullNames.Select (name => name.Split());
query1.Dump("Seleção simples nos possibilita um resultado de hierarquias");

// achatadas em coleção de strings
IEnumrable<string> query2 = fullNames.SelectMany<string, string>(name => name.Split());
query2.Dump("SelectMany possibilita um resultado plano");

//Achatamento direto - sem trabalho algum
IEnumerable<string> query3 = 
    from fullName in fullNames
    from name in fullName.Split()
    select name;

query3.DefaultIfEmpty("Same SelectMany query, but in query sintax");


//Concatenação
IEnumerable<string> query =
    from fullName in fullNames
    from name in fullName.Split()
    select name + " came from " + fullName;
query.Dump("Both variable are in scope");

//Concatenação
IEnumerable<string> query =
    from fullName in fullNames
    from name in fullName.Split()
    orderby fullName, name
    select name + " came from " + fullName;
query.Dump("Both variable are in scope");*/

