internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Ingrese el primer angulo:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo angulo:");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer angulo:");
        c = double.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Triangulo Equilatero");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Triangulo Isosceles");
        }
        else
        {
            Console.WriteLine("Triangulo Escaleno");
        }
    }
}