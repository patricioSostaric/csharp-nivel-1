namespace sueldos;
class Program
{
    static void Main(string[] args)
    {
        //4. Una casa de computación paga a sus empleados un sueldo fijo de 
        //ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
        //Hacer un programa para ingresar el total facturado por un empleado y que luego 
        //calcule y emita por pantalla el sueldo total a cobrar por el mismo.
        
        float sueldoTotal,sueldo;

        float comision,facturacion;
        comision=0.05f;
        sueldo=15000.00f;

        Console.WriteLine("ingrese el total facturado por el empleado ");
        facturacion=float.Parse(Console.ReadLine()??"0");

        sueldoTotal =sueldo+(facturacion*comision);
        
        Console.WriteLine("el sueldo total del empleado  es : " + sueldoTotal.ToString("0.00"));


    }
}

