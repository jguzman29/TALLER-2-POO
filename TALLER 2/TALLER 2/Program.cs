using System;
using System.Collections.Generic;
using TALLER_2;

namespace SistemaNomina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE NÓMINA EMPRESARIAL ===");
            List<IEmpleado> listaEmpleados = new List<IEmpleado>();

            try
            {
           
                listaEmpleados.Add(new EmpleadoTiempoCompleto("Michael Parra", 2500000));

              
                listaEmpleados.Add(new EmpleadoPorHoras("Juan Guzmán", 170, 40000));

                listaEmpleados.Add(new EmpleadoComision("Diego Leal", 1300000, 8000000));

                foreach (var empleado in listaEmpleados)
                {
                    empleado.MostrarInformacion();
                    Console.WriteLine("------------------------------------------");
                }
            }
            catch (ArgumentException ex) { 

            
                Console.WriteLine($"\n[ERROR DE VALIDACIÓN]: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERROR DEL SISTEMA]: {ex.Message}");
            }

           
            Console.ReadKey();
        }
    }
}