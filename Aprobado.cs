internal class Aprobado
{
    private static void Main(string[] args)
    {
        double nota;

        Console.WriteLine("Ingrese la calificacion:");
        nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 60)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}