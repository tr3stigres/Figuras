public class Paralelogramo : Poligono
{
    public double Lado1 { get; }
    public double Lado2 { get; }
    public double Grado1 { get; }
    public double Grado2 { get; }

    public Paralelogramo(double l1, double l2, double gr1, double gr2, string nombre) : base(4, nombre)
    {
        Lado1 = l1;
        Lado2 = l2;
        Grado1 = gr1;
        Grado2 = gr2;
    }

    public override string ToString()
    {
        return $"Figura: {NomFigura}, Lados: {Lado1}, {Lado2} Grados: {Grado1}, {Grado2}";
    }
}