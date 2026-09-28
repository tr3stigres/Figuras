public class Triangulo : Poligono
{
    public double Lado1 { get; }
    public double Lado2 { get; }
    public double Lado3 { get; }

    public Triangulo(double lado1, double lado2, double lado3) : base(3, "Triángulo")
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }
    public override string ToString()
    {
        return $"Figura: {NomFigura}, Lados: {Lado1}, {Lado2}, {Lado3}";
    }
}