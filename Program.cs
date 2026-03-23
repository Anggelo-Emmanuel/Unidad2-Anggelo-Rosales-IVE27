internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===Mensaje de voz===");
        //variable
        int opcion;
        //cREAR EL MENU
        Console.WriteLine("MENU PRINCIPAL");
        Console.WriteLine("1: recepcion");
        Console.WriteLine("2: vigilancia");
        Console.WriteLine("3: mantenimiento");
        Console.WriteLine("4: Salir");
        Console.WriteLine("Digite una opcion []: ");
        opcion=Convert.ToInt32(Console.ReadLine());
        //Condiciones
        if (opcion == 1)
        {
            //Limpiar pantalla
            Console.Clear();
            Console.WriteLine("Bienvenido al departamento de Recepcion");
        }
        if (opcion == 2)
            Console.WriteLine("Bienvenido al departamento de vigilancia");

        if (opcion == 3)
            Console.WriteLine("Bienvenido al departamento de mantenimiento");

        if (opcion !=1 && opcion!=2 && opcion!=3)
            Console.WriteLine("Saliendo del sistema");





    }
}