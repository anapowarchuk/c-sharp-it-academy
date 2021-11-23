TermometroLimite term = new TermometroLimite(){
    LimiteSuperior = 1
};

term.LimiteSuperiorAlcancado += (sender, e) => { //+= adiciona todos os metodos observadores no multicast delegate
    Console.WriteLine("Limite superior alcançado");
};

Console.WriteLine(term);
term.Aumentar(0.5);
Console.WriteLine(term);
term.Aumentar(0.5);
Console.WriteLine(term);
term.Aumentar(0.5);
Console.WriteLine(term);
term.Aumentar(0.5);
Console.WriteLine(term);