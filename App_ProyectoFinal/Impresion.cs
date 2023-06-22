using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ProyectoFinal
{
    public static class Impresion
    {
        public static void imprimir(StreamWriter sw, double[] arreglo, double resultado, string signo)
        {
            string cadenaNumeros = arreglo[0].ToString();
            for (int i = 1; i < arreglo.Length; i++)
            {
                cadenaNumeros += signo + arreglo[i];
            }
            string cadena = "el resultado de " + cadenaNumeros + " es " + resultado + " a " + DateTime.Now;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }

        public static void imprimir(StreamWriter sw, string accion, double[] arreglo, double resultado)
        {
            string cadenaNumeros = arreglo[0].ToString();
            for (int i = 1; i < arreglo.Length; i++)
            {
                cadenaNumeros += ", " + arreglo[i];
            }
            string cadena = "el resultado de " + accion + " de " + cadenaNumeros + " es " + resultado + " a " + DateTime.Now;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }
        public static void imprimir(StreamWriter sw, double altura, double kilos, double masa)
        {
            string cadena = "El resultado del calculo de masa corporal con un peso de " + kilos + "KG y una altura de " + altura + "CM es: " + masa + " a fecha de " + DateTime.Now;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }

        public static void ImprimirConversiones(StreamWriter sw, double valor, string conversion, double resultado)
        {
            string cadena = "El resultdo de convertir " + valor + " de " + conversion + " es " + resultado + " a fecha de " + DateTime.Now;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }

        public static void imprimirCuadrado(StreamWriter sw, double lado, double area)
        {
            string cadena = "El area de un cuadrado con lado " + lado + " es " + area;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }
        public static void imprimirTriangulo(StreamWriter sw, double ladoBase, double altura, double area)
        {
            string cadena = "El area de un triangulo con base " + ladoBase + " Y altura " + altura + " es " + area;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }
        public static void imprimirCirculo(StreamWriter sw, double radio, double area)
        {
            string cadena = "El area de un circulo con radio " + radio + " es " + area + " a fecha de " + DateTime.Now;
            Console.WriteLine(cadena);
            sw.WriteLine(cadena);
        }
    }
}
