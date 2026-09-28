public class Poligono : Figura
{
    public int NumLados { get; }


    public Poligono(int nLados, string nombre) : base(nombre)
    {
        NumLados = nLados;
    }

    public override double CalcularArea()
        => 0;
}