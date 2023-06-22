using System;
using System.IO;
using System.Linq;

namespace App_ProyectoFinal
{
    public static class OperacionesBasicas
    {
        public static double suma(double[] arreglo)
        {
            return arreglo.Sum();
        }

        public static double resta(double[] arreglo)
        {
            double resultado = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            { resultado -= arreglo[i]; }
            return resultado;
        }

        public static double multiplicacion(double[] arreglo)
        {
            double resultado = 1;
            foreach (double i in arreglo)
            { resultado *= i; }
            return resultado;
        }

        public static double division(double[] arreglo)
        {
            double resultado = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            { resultado /= arreglo[i]; }
            return resultado;
        }


        public static double media(double[] arreglo)
        { return arreglo.Average(); }

        public static double desviacionEstandar(double[] arreglo)
        {
            double sum = arreglo.Sum(d => Math.Pow(d - OperacionesBasicas.media(arreglo), 2));
            return Math.Sqrt((sum) / arreglo.Count());
        }

        public static double mediana(double[] arreglo)
        {
            Array.Sort(arreglo);
            return arreglo[arreglo.Length / 2];
        }

        public static double moda(double[] arreglo)
        {
            double maxNumero = arreglo[0];
            int maxVeces = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                int numVeces = 0;
                for (int j = 0; j < arreglo.Length; j++)
                { if (arreglo[j] == arreglo[i]) { numVeces++; } }

                if (numVeces > maxVeces)
                {
                    maxNumero = arreglo[i];
                    maxVeces = numVeces;
                }
            }
            return maxNumero;
        }

        public static double IMC(double altura, double kilos)
        {
            double alturaM2 = altura;
            alturaM2 = alturaM2 * alturaM2;
            return kilos / (alturaM2 / 10000);
        }

        
    }
}
