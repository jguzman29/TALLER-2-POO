using System;
using System.Collections.Generic;
using System.Text;

namespace TALLER_2
{
    public class EmpleadoPorHoras : IEmpleado
    {
        protected string Nombre;
        protected int HorasTrabajadas;
        protected double ValorHora;

        public EmpleadoPorHoras(string nombre, int horas, double valor)
        {
            if (horas <= 0) throw new ArgumentException("Horas deben ser mayores a 0");
            this.Nombre = nombre;
            this.HorasTrabajadas = horas;
            this.ValorHora = valor;
        }

        public double CalcularSalarioBruto()
        {
            if (HorasTrabajadas <= 160)
                return HorasTrabajadas * ValorHora;

            int extras = HorasTrabajadas - 160;
            double pagoNormal = 160 * ValorHora;
            double pagoExtras = extras * (ValorHora * 1.15); 
            return pagoNormal + pagoExtras;
        }

        public double CalcularDescuentos() => CalcularSalarioBruto() * 0.04; 

        public double CalcularSalarioNeto() => CalcularSalarioBruto() - CalcularDescuentos();

        public void MostrarInformacion()
        {
            Console.WriteLine($"\n--- Empleado por Horas: {Nombre} ---");
            Console.WriteLine($"Horas: {HorasTrabajadas} | Valor Hora: {ValorHora:C}");
            Console.WriteLine($"Salario Bruto: {CalcularSalarioBruto():C}");
            Console.WriteLine($"Salario Neto: {CalcularSalarioNeto():C}");
        }
    }
}
