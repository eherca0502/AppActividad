using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppActividad
{
    public class Nomina
    {
        private int diasLaborados;

        public int DiasLaborados { get; set; }

        //Metodo´para calcular nomina
        public decimal CalcularNomina(int diasLaborados,decimal valorDia)
        {
            decimal totalSalario=diasLaborados*valorDia;
            return totalSalario;
        }
    }
}
