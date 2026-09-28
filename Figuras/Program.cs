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

        figura = new Pentagono(2);
        MostrarFigura(figura);

        figura = new Triangulo(8, 6, 5);
        MostrarFigura(figura);

        figura = new Rectangulo(3, 4);
        MostrarFigura(figura);

        figura = new Cuadrado(2);
        MostrarFigura(figura);

        figura = new Rombo(3, 95);
        MostrarFigura(figura);
    }

    public static void MostrarFigura(Figura figura)
    {
        Console.WriteLine($"{figura.ToString()}");
        Console.WriteLine($"Área: {figura.CalcularArea():F4}\n");
    }

    public static void CalculoDiagrama()
    {
        double areaTotal = 0;
        string figurasUsadas = "";
        Random numAleatori = new Random();
        int numFormes = numAleatori.Next(1,14);
        int forma = 0;
        List<Figura> lista = new List<Figura> {};

        for (int i=0;i<numFormes; i++)
        {
            forma = numAleatori.Next(1, 7);
            switch(forma)
            {
                case 1:
                    lista.Add(new Ovalo(2, 3));
                    break;
                case 2:
                    lista.Add(new Circulo(5));
                    break;
                case 3:
                    lista.Add(new Pentagono(2));
                    break;
                case 4:
                    lista.Add(new Triangulo(8, 6, 5));
                    break;
                case 5:
                    lista.Add(new Rectangulo(3, 4));
                    break;
                case 6:
                    lista.Add(new Cuadrado(2));
                    break;
                case 7:
                    lista.Add(new Rombo(3, 95));
                    break;
            };
        }
        
        foreach (Figura figura in lista)
        {
            areaTotal += figura.CalcularArea();
            figurasUsadas += figura.NomFigura + ", ";
        }

        Console.WriteLine($"\n\nEl área total de los {numFormes} elementos ({figurasUsadas.TrimEnd(',', ' ').Trim()}): {areaTotal:F4}");
    }

    

}
