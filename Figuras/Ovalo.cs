public class Ovalo : Figura
{
    public double Radio1 { get; }
    public double Radio2 { get; }
    

    public Ovalo(double r1, double r2, string nombre = "Óvalo") : base(nombre)
    {
        Radio1 = r1;
        Radio2 = r2;        
    }
    public override string ToString()
    {
        return $"Figura: {NomFigura}, Radio: {Radio1},  Radio: {Radio2}";
    }

    public override double CalcularArea()
    => Math.PI * Radio1 * Radio2;
}