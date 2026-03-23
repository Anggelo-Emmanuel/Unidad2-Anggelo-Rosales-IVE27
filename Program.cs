internal class Program
{
   
    private static void Main(string[] args)
    {
        Console.WriteLine("===Promedo notas===");
        int n1, n2, n3, n4, n5;
        string materia;
        Console.WriteLine("Digite la materia");
        materia =Console.ReadLine();
        Console.WriteLine("Digite 5 notas: ");
        n1=Convert.ToInt32(Console.ReadLine());
        n2=Convert.ToInt32(Console.ReadLine());
        n3=Convert.ToInt32(Console.ReadLine());
        n4=Convert.ToInt32(Console.ReadLine());
        n5=Convert.ToInt32(Console.ReadLine());

        double promedio = (n1 + n2 + n3 + n4 + n5) / 5;
        if (promedio >= 70)
            Console.WriteLine("Estudiante aprobado");
        else
            Console.WriteLine("Estudiante reprobado");

        Console.WriteLine("La materia: "+materia);
        Console.WriteLine("El promedio: "+promedio);
    } 
}