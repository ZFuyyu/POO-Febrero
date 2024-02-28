using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Persona objPersona;
            objPersona = new Persona();

            Console.WriteLine("Ingrese su nombre");
            objPersona.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            objPersona.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese las horas trabajadas");
            objPersona.horario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de cada hora");
            objPersona.valor = Convert.ToInt32(Console.ReadLine());

            objPersona.calcSueldo(objPersona.horario, objPersona.valor);
            objPersona.mostrarDatos();x
        }
    }

}
public class Persona
{
    public Persona() { }
    public string nombre;
    public string apellido;
    public int horario;
    public int valor;
    public int sueldo;
    public Persona(string nombre, string apellido, int horario, int valor)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.horario = horario;
        this.valor = valor;

    }
    public void calcSueldo(int horas, int valor)
    {
        this.sueldo = horas * valor;
    }
    public void mostrarDatos()
    {
        Console.WriteLine("El empleado {0} {1} que trabaja {2} horas gana {3} por hora, su sueldo es {4}", nombre, apellido, horario, valor, sueldo);
        Console.ReadLine();
    }
}
/*/// <param name="bueno"></param>
        static double Pato3(string bueno )
        {
            Console.WriteLine(bueno);
            double inputnumber;
            while (!double.TryParse(Console.ReadLine(), out inputnumber))
            {
                Console.WriteLine();
            }
            return inputnumber;

        }
        static string Pato2(string bueno)
        {
            Console.WriteLine(bueno);
            string Pato = Console.ReadLine();
          
            return Pato;
        }
        static void Main(string[] args)
        {
            string Nombre = Pato2("Ingrese un nombre: ");
            string Apellido = Pato2("Ingrese un apellido:");
            double HoraTrabajo = Pato3("Ingrese Horas Trabajadas:");
            double HoraValor = Pato3("Ingrese valor de hora:");
 
            Console.WriteLine(HoraTrabajo * HoraValor);
            Console.ReadKey();
             
        }*/