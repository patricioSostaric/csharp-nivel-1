namespace suma;
class Program
{
    static void Main(string[] args)
    {
         int n1;
         int n2,resultado;


            Console.WriteLine("ingrese un numero");
            n1=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese otro numero");
            n2 =int.Parse(Console.ReadLine());
            
            resultado=n1+n2;
            Console.Write( "la suma es :" + resultado);
    }
}
