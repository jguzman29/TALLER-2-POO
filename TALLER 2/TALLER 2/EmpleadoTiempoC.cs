using System;
using System.Collections.Generic;
using System.Text;

namespace TALLER_2
{
    public class EmpleadoTiempoCompleto : IEmpleado
    {
        protected string Nombre;
        protected double SalarioBase;
        protected double Bonificacion; 

        public EmpleadoTiempoCompleto(string nombre, double salarioBase)
        {
            if (salarioBase < 0) throw new ArgumentException("El salario no puede ser negativo");
            this.Nombre = nombre;
            this.SalarioBase = salarioBase;
            this.Bonificacion = salarioBase * 0.10;
        }

        public double CalcularSalarioBruto() => SalarioBase + Bonificacion;

        public double CalcularDescuentos() => CalcularSalarioBruto() * 0.08;

        public double CalcularSalarioNeto() => CalcularSalarioBruto() - CalcularDescuentos();

        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado Tiempo Completo: {Nombre} ---");
            Console.WriteLine($"Salario Base: {SalarioBase:C}");
            Console.WriteLine($"Bonificación (10%): {Bonificacion:C}");
            Console.WriteLine($"Descuentos (8%): {CalcularDescuentos():C}");
            Console.WriteLine($"Salario Neto: {CalcularSalarioNeto():C}");
        }
    }
}
