public class Rectangulo : Paralelogramo
{
    
    public Rectangulo(double l1, double l2, string nombre = "Rectángulo") : base(l1,l2,90,90, nombre)
    {        

    }

    public override double CalcularArea()
        => Lado1 * Lado2;
}