internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine("1 Ventas");
        Console.WriteLine("2 Recepcion");
        Console.WriteLine("3 Direccion");
        Console.WriteLine("4 Compras");

        opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Bienvenido a Ventas");
            Console.WriteLine("ventas@empresa.com");
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Bienvenido a Recepcion");
            Console.WriteLine("recepcion@empresa.com");
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Bienvenido a Direccion");
            Console.WriteLine("direccion@empresa.com");
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Bienvenido a Compras");
            Console.WriteLine("compras@empresa.com");
        }
        else
        {
            Console.WriteLine("Opcion invalida");
        }
    }
}