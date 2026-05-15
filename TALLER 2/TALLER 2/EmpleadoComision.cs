using System;
using System.Collections.Generic;
using System.Text;

namespace TALLER_2
{
    public class EmpleadoComision : IEmpleado
    {
        protected string Nombre;
        protected double SalarioBase;
        protected double Ventas;

        public EmpleadoComision(string nombre, double baseSal, double ventas)
        {
            if (ventas < 0) throw new ArgumentException("Ventas no pueden ser negativas");
            this.Nombre = nombre;
            this.SalarioBase = baseSal;
            this.Ventas = ventas;
        }

        public double CalcularSalarioBruto() => SalarioBase + (Ventas * 0.08);

        public double CalcularDescuentos() => CalcularSalarioBruto() * 0.05; 

        public double CalcularSalarioNeto() => CalcularSalarioBruto() - CalcularDescuentos();

        public void MostrarInformacion()
        {
            Console.WriteLine($"\n--- Empleado por Comisión: {Nombre} ---");
            Console.WriteLine($"Ventas: {Ventas:C} | Comisión (8%): {(Ventas * 0.08):C}");
            Console.WriteLine($"Salario Neto: {CalcularSalarioNeto():C}");
        }
    }
}