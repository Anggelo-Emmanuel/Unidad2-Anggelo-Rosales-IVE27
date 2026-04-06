internal class Program
{
    private static void Main(string[] args)
    {
        int dia;

        Console.WriteLine("Ingrese un numero del 1 al 7:");
        dia = Convert.ToInt32(Console.ReadLine());

        if (dia == 6 || dia == 7)
        {
            Console.WriteLine("Fin de semana");
        }
        else
        {
            Console.WriteLine("Entre semana");
        }
    }
}