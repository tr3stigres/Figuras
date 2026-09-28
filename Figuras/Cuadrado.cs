public class Cuadrado : Rectangulo
{

    public Cuadrado(double l1) : base(l1, l1, "Cuadrado")
    {

    }

    public override double CalcularArea()
        => Lado1 * Lado1;

}