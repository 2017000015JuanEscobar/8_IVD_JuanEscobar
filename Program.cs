
internal class Program
{
    private static void Main(string[] args)
    {
        //entrada
        Console.WriteLine("Numeros positivos o negativos");
        int num;
        Console.Write("Dame un número entero:");
        num = Convert.ToInt32(Console.ReadLine());
        //proceso
        //salida
        if (num >= 0)
        { 
            Console.WriteLine("Es un numero positivo");
        }
        else
        {
            Console.WriteLine("Es un numero negativo");
        }
    }
}