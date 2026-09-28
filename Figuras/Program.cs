using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        try
        {
            CalculoAreas();
            CalculoDiagrama();
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

    public static void CalculoAreas()
    {
        Figura figura = new Ovalo(2, 3);
        MostrarFigura(figura);

        figura = new Circulo(5);
        MostrarFigura(figura);

        figura = new Pentagono(324);
        MostrarFigura(figura);

        figura = new Triangulo(343, 452, 342);
        MostrarFigura(figura);

        figura = new Rectangulo(23, 59);
        MostrarFigura(figura);

        figura = new Cuadrado(98);
        MostrarFigura(figura);

        figura = new Rombo(23, 34);
        MostrarFigura(figura);
    }

    public static void MostrarFigura(Figura figura)
    {
        Console.WriteLine($"{figura.ToString()}");
        Console.WriteLine($"Área: {figura.CalcularArea():F4}");
    }

    public static void CalculoDiagrama()
    {
        double areaTotal = 0;
        string figurasUsadas = "";

        List<Figura> lista = new List<Figura> { new Ovalo(2, 3), new Circulo(5), new Cuadrado(98), new Cuadrado(12) };

        foreach (Figura figura in lista)
        {
            areaTotal += figura.CalcularArea();
            figurasUsadas += figura.NomFigura + ", ";
        }

        Console.WriteLine($"El área total de {figurasUsadas}: {areaTotal:F4}");
    }

    

}
