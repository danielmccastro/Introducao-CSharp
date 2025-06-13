class Program
{
    public static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Albert", "Einstein", new DateTime(1955, 6, 17), "12345678900");
        p1.Peso = 76;
        p1.Altura = 1.78;
        p1.MostrarDados();

        p1.Comer(2.5);
        p1.Comer(3800);
        p1.Correr(7, 30);
        p1.MostrarDados();

        Console.WriteLine("");

        Pessoa p2 = new Pessoa("Ada", "Lovelace", new DateTime(1974, 4, 18), "12345678900", 62, 1.65);
        p2.MostrarDados();

        p2.Comer(2.5);
        p2.Comer(3800);
        p2.Correr(7, 30);
        p2.MostrarDados();
    }
}