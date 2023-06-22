using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App_ProyectoFinal
{
    internal static class Conversiones
    {
        public static double KilometrosAMetros(double valor)
        {
            double[] valores = new double[2] { valor, 1000 };
            return OperacionesBasicas.multiplicacion(valores);
        }
        public static double KilometroACentimetros(double valor)
        {
            double[] valores = new double[2] {valor, 100000 };
            return OperacionesBasicas.multiplicacion(valores);
        }
        public static double KilometrosAMillas(double valor)
        {
            double[] valores = new double[2] { valor, 1.609 };
            return OperacionesBasicas.division(valores);
        }
        public static double MillasAMetros(double valor)
        {
            double[] valoresM = new double[2] { valor, 1.609 };
            double[] valoresD = new double[2] { OperacionesBasicas.multiplicacion(valoresM), 1000 };
            return OperacionesBasicas.division(valoresD);
        }
        public static double MillasAKilometros(double valor)
        {
            double[] valores = new double[2] { valor, 1.609 };
            return OperacionesBasicas.multiplicacion(valores);
        }
        public static double PulgadasACentimetros(double valor)
        {
            double[] valores = new double[2] { valor, 2.54 };
            return OperacionesBasicas.multiplicacion(valores);
        }
        public static double CentimetrosAPulgadas(double valor)
        {
            double[] valores = new double[2] { valor, 2.54 };
            return OperacionesBasicas.division(valores);
        }
        public static double MilimetrosACentimetros(double valor)
        {
            double[] valores = new double[2] { valor, 10 };
            return OperacionesBasicas.division(valores);
        }
        public static double MilimetrosAMetros(double valor)
        {
            double[] valores = new double[2] { valor, 1000 };
            return OperacionesBasicas.division(valores);
        }
        public static double MilimetrosAPulgadas(double valor)
        {
            double[] valores = new double[2] { valor, 25.4 };
            return OperacionesBasicas.division(valores);
        }
        public static double CentigradosAFahrenheit(double valor)
        {
            double[] valoresM = new double[2] { valor, 9 };
            double[] valoresD = new double[2] { OperacionesBasicas.multiplicacion(valoresM), 5 };
            double[] valoresS = new double[2] { OperacionesBasicas.division(valoresD), 32 };
            return OperacionesBasicas.division(valoresS);
        }

        public static double CentigradosAKelvin(double valor)
        {
            double[] valores = new double[2] { valor, 273.15};
            return OperacionesBasicas.division(valores);
        }

        public static double FahrenheitACentigrados(double valor)
        {
            double[] valoresR = new double[2] { valor, 32 };
            double[] valoresM = new double[2] {OperacionesBasicas.resta(valoresR), 5 };
            double[] valoresd = new double[2] { OperacionesBasicas.multiplicacion(valoresM), 9 };
            return OperacionesBasicas.division(valoresd);
        }

        public static double FahrenheitAKelvin(double valor)
        {
            double[] valoresR = new double[2] { valor, 32 };
            double[] valoresM = new double[2] { OperacionesBasicas.resta(valoresR), 5 };
            double[] valoresd = new double[2] { OperacionesBasicas.multiplicacion(valoresM), 9 };
            double[] valoresS = new double[2] { OperacionesBasicas.division(valoresd), 237.15 };
            return OperacionesBasicas.suma(valoresS);
        }

        public static double KelvinAFahrenheit(double valor)
        {
            double[] valoresR = new double[2] { valor, 237.15 };
            double[] valoresM = new double[2] { OperacionesBasicas.resta(valoresR), 9 };
            double[] valoresd = new double[2] { OperacionesBasicas.multiplicacion(valoresM), 5 };
            double[] valoresS = new double[2] { OperacionesBasicas.division(valoresd), 32 };
            return OperacionesBasicas.suma(valoresS);
        }

        public static double KelvinACentigrados(double valor)
        {
            double[] valoresR = new double[2] { valor, 237.15 };
            return OperacionesBasicas.resta(valoresR);
        }

    }
}
