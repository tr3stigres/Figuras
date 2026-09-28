public class Rombo : Paralelogramo
{
    
    public Rombo(double lado, double gr1) : base(lado, lado, gr1, (180-gr1), "Rombo")
    {

    }

    public override double CalcularArea()
           => Lado1 * Lado2 * Math.Sin(Grado1);

}