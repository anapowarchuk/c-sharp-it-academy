public delegate void ReferenciaMetodoVoid();


public class UmaClasseQualquer{
    public void MetodoQualquer(){
        Console.WriteLine("MetodoQualquer");
    }

    public static void MetodoQualquerStatic() {
        Console.WriteLine("MetodoQualquerStatic");
    }

    public static int FazUmCalculo(int x, Func<int,int, int> f){
        return f(x,x);
    }

    public static Func<int, int> ControiMetodo(){ //cria um metodo que devolve outro metodo
        return (int y) => x + y;
    }
}