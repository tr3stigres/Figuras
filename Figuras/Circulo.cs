public class Circulo : Ovalo
{
    public double RadioCirculo { get; }   

    public Circulo(double radio) : base(radio, radio, "Círculo")
    {
        RadioCirculo = radio;
    }

    public override string ToString()
    {
        return $"Figura: {NomFigura}, Radio : {RadioCirculo}";
    }

    public override double CalcularArea()
    => Math.PI * RadioCirculo * RadioCirculo;

}