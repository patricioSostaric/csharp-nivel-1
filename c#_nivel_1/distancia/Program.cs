using System;

namespace distancia

{
    class Program
    {
        static void Main(string[] args)
        {
            float km;
            float velocidad,resultado;


            Console.WriteLine("ingrese la distancia entre  las ciudades");
            km=float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la velocidad promedio del vehiculo");
            velocidad=float.Parse(Console.ReadLine());
            
            resultado= (float)(km / velocidad);
            Console.Write( "el tiempo estimado de viaje es  : " + resultado +" hs");
        }
    }
}
