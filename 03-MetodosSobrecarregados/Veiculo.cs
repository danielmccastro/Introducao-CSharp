using System;

enum CorVeiculo
{
    Branco,
    Preto,
    Vermelho,
    Prata,
    Grafite
}
class Veiculo
{
    public string Modelo { get; set; }

    public int Peso { get; set; }

    public double Velocidade { get; set; }
    public int Portas { get; set; }
    public CorVeiculo Cor { get; set; }

    public Veiculo(string modelo)
    {
        this.Modelo = modelo;
    }

    public Veiculo(string modelo, CorVeiculo cor) : this(modelo)
    {
        this.Cor = cor;
    }

    public Veiculo(string modelo, CorVeiculo cor, int portas = 4) : this(modelo, cor)
    {
        this.Portas = portas;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Modelo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} Portas");
    }

    public void MostrarDados(int nroLinha)
    {
        Console.WriteLine($"{nroLinha}. Modelo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} Portas");

    }

    /// <summary>
    /// Acelera o veiculo
    /// </summary>
    public void Acelerar()
    {
        this.Velocidade = 0;
        this.Velocidade += 10;
    }

    /// <summary>
    /// Acelera o veiculo
    /// </summary>
    /// <param name="acrescimo">Quantidade a ser aumentada</param>
    public void Acelerar(int acrescimo)
    {
        this.Velocidade += acrescimo;
    }

    /// <summary>
    /// Acelera o veiculo
    /// </summary>
    /// <param name="acrescimoPorSegundo">Quantidade a ser aumentada</param>
    /// <param name="tempoSeg">Tempo de aceleração em segundos</param>
    public void Acelerar(int acrescimoPorSegundo, double tempoSeg)
    {
        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(tempoSeg);
        while (inicio < fim)
        {
            this.Velocidade += acrescimoPorSegundo;
            Thread.Sleep(1000);
            Console.WriteLine($"Velocidade atual: {this.Velocidade:F2} km/h");
            inicio = inicio.AddSeconds(1);
        }
    }

}
