using System;
class Program
{

    static Program()
    {
        Console.WriteLine("Programa iniciado com sucesso.");
    }

    static void CriarObjetos()
    {
        Carro c1 = new Carro();
        c1.Modelo = "Fusca";
        c1.Portas = 4;
        c1.Preco = 29990;

        Carro c2 = new Carro();
        c2.Modelo = "Opala";
        c2.Portas = 4;
        c2.Preco = 49990;

        Carro c3 = new Carro("Chevete");
        c3.Portas = 4;
        c3.Preco = 0;

        Carro c4 = new Carro("Monza", 4, 39990);

        Carro c5 = new Carro(1190);

    }
    public static void Main(String[] args)
    {
        CriarObjetos();
        Console.WriteLine("Objetos ja nao sao mais utilizados.");
        GC.Collect();
        GC.WaitForPendingFinalizers(); // Aguarda execução dos finalizadores
        Console.WriteLine("Finalizadores devem ter sido executados.");
    }
}