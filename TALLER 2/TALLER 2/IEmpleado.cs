using System;
using System.Collections.Generic;
using System.Text;

namespace TALLER_2
{
    public interface IEmpleado
        {
            double CalcularSalarioBruto();
            double CalcularDescuentos();
            double CalcularSalarioNeto();
            void MostrarInformacion();
        }
    }

 