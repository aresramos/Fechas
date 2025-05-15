using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame fecha en formato dd/MM/yyyy");
            DateTime fecha = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Tu fecha introducida larga es: {fecha}");
            Console.WriteLine($"Tu fecha introducida sin hora es: {fecha.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"tu fecha introducida corta es: {fecha.ToString("dd/MM/yy")}");
            DateTime fechaactual = DateTime.Now;
            DateTime fechahoy = DateTime.Today;

            Console.WriteLine($"fecha actual: {fechaactual}");
            Console.WriteLine($"fecha hoy: {fechahoy}");

            Console.WriteLine("Dame usuario: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("Dame contraseña: ");
            string password = Console.ReadLine();
            Console.WriteLine("Dame fecha de nacimiento:");
            DateTime fechanacimiento = Convert.ToDateTime(Console.ReadLine());
            int edad = fechaactual.Year -fechanacimiento.Year;

            Console.ReadKey();
        }
    }
}
