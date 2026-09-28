public class Pentagono : Poligono
{
    public double LargoLado { get; }
    
    public Pentagono(double largo) : base(5, "Pentágono")
    {
        LargoLado = largo;
    }
    public override string ToString()
    {
        return $"Figura: {NomFigura}, Largo: {LargoLado}, Número de lados: {NumLados}";
    }

    public override double CalcularArea()
    {
        double perimetro = NumLados * LargoLado;
        double apotema = LargoLado / (2 * Math.Tan(36));        
        return (perimetro * apotema) / 2;
    }
    
}