using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        try
        {
            Figura figura = new Ovalo(2, 3);
            Console.WriteLine($"{figura.ToString()}");

            figura = new Circulo(5);
            Console.WriteLine($"{figura.ToString()}");

            figura = new Pentagono(324);
            Console.WriteLine($"{figura.ToString()}");

            figura = new Triangulo(343,452,342);
            Console.WriteLine($"{figura.ToString()}");

            figura = new Rectangulo(23, 59);
            Console.WriteLine($"{figura.ToString()}");

            figura = new Cuadrado(98);
            Console.WriteLine($"{figura.ToString()}");

            figura = new Rombo(23, 45, 34);
            Console.WriteLine($"{figura.ToString()}");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }
}
