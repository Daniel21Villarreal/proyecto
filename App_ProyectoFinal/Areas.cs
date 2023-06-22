using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ProyectoFinal
{
    public static class Areas
    {
        public static double AreaCuadrado(double lado)
        {
            double[] arreglo = new double[2] { lado, lado };
            return OperacionesBasicas.multiplicacion(arreglo); 
        }
        public static double AreaTriangulo(double ladoBase, double altura)
        {
            double[] arregloM = new double[2] {ladoBase, altura};
            double[] arregloD = new double[2] {OperacionesBasicas.multiplicacion(arregloM), 2};
            return OperacionesBasicas.division(arregloD); 
        }
        public static double AreaCirculo(double radio)
        {
            double[] arregloR = new double[2] { radio, radio };
            return Math.Round(Math.PI * OperacionesBasicas.multiplicacion(arregloR), 5); 
        }
    }
}
