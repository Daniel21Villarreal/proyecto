using System;
using System.IO;
using System.Diagnostics;

namespace App_ProyectoFinal
{
    class Program
    {

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("texto.txt");

            bool terminarProgramma = false;
            while (!terminarProgramma)
            {
                Console.Clear();

                Console.WriteLine("Bienvenido, por favor seleccione una de las siguientes opciones\n");
                Console.WriteLine("1. OPERACIONES \n\r ");
                Console.WriteLine("2. CALCULAR AREAS \n\r");
                Console.WriteLine("3. CALCULAR MASA CORPORAL \n\r");
                Console.WriteLine("4. CONVERSIONES \n\r");
                Console.WriteLine(" T para terminar\n\r");

                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "T")
                {
                    terminarProgramma = true;
                    continue;
                }
                int seleccion;
                if (!int.TryParse(respuesta, out seleccion))
                {
                    Console.WriteLine("error, presione enter para volver a intentarlo");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    switch (seleccion)
                    {
                        case 1:
                            {
                                Console.WriteLine("1. SUMA");
                                Console.WriteLine("2. RESTA");
                                Console.WriteLine("3. MULTIPLICACION");
                                Console.WriteLine("4. DIVISION");
                                Console.WriteLine("5. Promedio");
                                Console.WriteLine("6. Desviacion estandar");
                                Console.WriteLine("7. Mediana ");
                                Console.WriteLine("8. Moda");
                                int opcionOperaciones = int.Parse(Console.ReadLine());

                                Console.WriteLine("ingresa el tamano del arreglo: ");
                                int tamanoArreglo = int.Parse(Console.ReadLine());
                                double[] arreglo = new double[tamanoArreglo];
                                for (int i = 0; i < arreglo.Length; i++)
                                {
                                    Console.WriteLine("ingrese el valor en la posicion ");
                                    arreglo[i] = double.Parse(Console.ReadLine());
                                }
                                if (opcionOperaciones == 1)
                                {
                                    Impresion.imprimir(sw, arreglo, OperacionesBasicas.suma(arreglo), " + ");
                                }
                                if (opcionOperaciones == 2)
                                {
                                    Impresion.imprimir(sw, arreglo, OperacionesBasicas.resta(arreglo), " - ");
                                }
                                if (opcionOperaciones == 3)
                                {
                                    Impresion.imprimir(sw, arreglo, OperacionesBasicas.multiplicacion(arreglo), " x ");
                                }
                                if (opcionOperaciones == 4)
                                {
                                    Impresion.imprimir(sw, arreglo, OperacionesBasicas.division(arreglo), " / ");
                                }
                                if (opcionOperaciones == 5)
                                {
                                    Impresion.imprimir(sw, "Promedio", arreglo, OperacionesBasicas.media(arreglo)) ;
                                }
                                if (opcionOperaciones == 6)
                                {
                                    Impresion.imprimir(sw, "Desviacion estandar", arreglo, OperacionesBasicas.desviacionEstandar(arreglo));
                                }
                                if (opcionOperaciones == 7)
                                {
                                    Impresion.imprimir(sw, "mediana", arreglo, OperacionesBasicas.mediana(arreglo));
                                }
                                if (opcionOperaciones == 8)
                                {
                                    Impresion.imprimir(sw, "moda", arreglo, OperacionesBasicas.moda(arreglo));
                                }

                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("1. Cuadrado");
                                Console.WriteLine("2. Triangulo");
                                Console.WriteLine("3. Circulo");
                                int opcionAreas = int.Parse(Console.ReadLine());
                                if (opcionAreas == 1)
                                {
                                    Console.WriteLine("Ingresa las unidades del lado del cuadrado");
                                    double lado = double.Parse(Console.ReadLine());
                                    Impresion.imprimirCuadrado(sw, lado, Areas.AreaCuadrado(lado));
                                }
                                if (opcionAreas == 2)
                                {
                                    Console.WriteLine("Ingresa las unidades de la base del triangulo");
                                    double ladoBase = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingresa las unidades de la altura del triangulo");
                                    double altura = double.Parse(Console.ReadLine());
                                    Impresion.imprimirTriangulo(sw, ladoBase, altura, Areas.AreaTriangulo(ladoBase,altura));
                                }
                                if (opcionAreas == 3)
                                {
                                    Console.WriteLine("Ingresa las unidades del radio del circulo");
                                    double radio = double.Parse(Console.ReadLine());
                                    Impresion.imprimirCirculo(sw, radio, Areas.AreaCirculo(radio));
                                }
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Ingrese los kilos: ");
                                double kilos = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese su altura en centimetros: ");
                                int altura = int.Parse(Console.ReadLine());

                                Impresion.imprimir(sw, altura, kilos, OperacionesBasicas.IMC(altura, kilos));

                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Que quisiera convertir?... ");
                                Console.WriteLine("1. Temperaturas");
                                Console.WriteLine("2. Distancias");
                                int opcionConversiones = int.Parse(Console.ReadLine());
                                if (opcionConversiones == 1)
                                {
                                    Console.WriteLine("1. Centigrados a fahrenheit");
                                    Console.WriteLine("2. Centigrados a kelvin ");
                                    Console.WriteLine("3. Fahrenheit a centigrados");
                                    Console.WriteLine("4. Fahrenheit a kelvin");
                                    Console.WriteLine("5 Kelvin a Fahrenheit");
                                    Console.WriteLine("6. Kelvin a centigrados");
                                    int conversion = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese el valor a convertir");
                                    double valor = double.Parse(Console.ReadLine());

                                    switch (conversion)
                                    {
                                        case 1: { Impresion.ImprimirConversiones(sw, valor, "centigrados a fahrenheit", Conversiones.CentigradosAFahrenheit(valor)); break; }
                                        case 2: { Impresion.ImprimirConversiones(sw, valor, "centigrados a kelvin", Conversiones.CentigradosAFahrenheit(valor)); break; }
                                        case 3: { Impresion.ImprimirConversiones(sw, valor, "fahrenheit a centigrados", Conversiones.FahrenheitACentigrados(valor)); break; }
                                        case 4: { Impresion.ImprimirConversiones(sw, valor, "fahrenheit a kelvin", Conversiones.FahrenheitAKelvin(valor)); break; }
                                        case 5: { Impresion.ImprimirConversiones(sw, valor, "kelvin a fahrenheit", Conversiones.KelvinAFahrenheit(valor)); break; }
                                        case 6: { Impresion.ImprimirConversiones(sw, valor, "kelvin a centigrados", Conversiones.KelvinACentigrados(valor)); break; }
                                    }
                                }
                                if (opcionConversiones == 2)
                                {
                                    Console.WriteLine("1. Kilometros a metros");
                                    Console.WriteLine("2. Kilometros a centimetros ");
                                    Console.WriteLine("3. Kilometros a Millas");
                                    Console.WriteLine("4. Millas a metros");
                                    Console.WriteLine("5. Millas a Kilometros");
                                    Console.WriteLine("6. pulgadas a centimetros");
                                    Console.WriteLine("7. centimetros a pulgadas ");
                                    Console.WriteLine("8. Milimetros a centimetros");
                                    Console.WriteLine("9. Milimetros a metros");
                                    Console.WriteLine("10. Milimetros a pulgadas");
                                    int conversion = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese el valor a convertir");
                                    double valor = double.Parse(Console.ReadLine());

                                    switch (conversion)
                                    {
                                        case 1: { Impresion.ImprimirConversiones(sw, valor, "Kilometros a metros", Conversiones.KilometrosAMetros(valor)); break; }
                                        case 2: { Impresion.ImprimirConversiones(sw, valor, "Kilometros a centimetros", Conversiones.KilometroACentimetros(valor)); break; }
                                        case 3: { Impresion.ImprimirConversiones(sw, valor, "Kilometros a Millas", Conversiones.KilometrosAMillas(valor)); break; }
                                        case 4: { Impresion.ImprimirConversiones(sw, valor, "Millas a metros", Conversiones.MillasAMetros(valor)); break; }
                                        case 5: { Impresion.ImprimirConversiones(sw, valor, "Millas a Kilometros", Conversiones.MillasAKilometros(valor)); break; }
                                        case 6: { Impresion.ImprimirConversiones(sw, valor, "pulgadas a centimetros", Conversiones.PulgadasACentimetros(valor)); break; }
                                        case 7: { Impresion.ImprimirConversiones(sw, valor, "centimetros a pulgadas", Conversiones.CentimetrosAPulgadas(valor)); break; }
                                        case 8: { Impresion.ImprimirConversiones(sw, valor, "Milimetros a centimetros", Conversiones.MilimetrosACentimetros(valor)); break; }
                                        case 9: { Impresion.ImprimirConversiones(sw, valor, "Milimetros a metros", Conversiones.MilimetrosAMetros(valor)); break; }
                                        case 10: { Impresion.ImprimirConversiones(sw, valor, "Milimetros a pulgadas", Conversiones.MilimetrosAPulgadas(valor)); break; }
                                    }
                                }
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("opcion invalida, presione enter para volver a intentarlo");
                                Console.ReadKey();
                                continue;
                            }
                    }
                }
                catch
                { Console.WriteLine("error... presione enter para volver a intentar..."); Console.ReadKey(); continue; }

                Console.ReadKey();
            }
            sw.Close();
            Process.Start("texto.txt");
        }
    }
}
