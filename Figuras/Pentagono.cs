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
}