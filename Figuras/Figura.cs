public abstract class Figura
{
    public string NomFigura { get; }
    protected Figura(string nombre)
    {
        NomFigura = nombre;
    }

    public abstract double CalcularArea();

    
}