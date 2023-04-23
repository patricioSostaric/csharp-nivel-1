namespace cubo;
class Program
{
    static void Main(string[] args)
    {
        int n,resultado;

        Console.WriteLine("ingrese un numero");
       n=int.Parse(Console.ReadLine()??"0");
       resultado=n*n*n;


        Console.WriteLine("el cubo de "+ n + " es : "+ resultado);
    }
}
