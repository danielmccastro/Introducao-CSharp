class Program
{
    static void Main(string[] args)
    {
        Veiculo v1 = new Veiculo("Fusca", CorVeiculo.Branco, 2);
        v1.MostrarDados(1);
        Veiculo v2 = new Veiculo("Opala", CorVeiculo.Preto, 4);
        v2.MostrarDados(2);
        v2.Acelerar(5, 10);
        v2.Acelerar();
    }
}