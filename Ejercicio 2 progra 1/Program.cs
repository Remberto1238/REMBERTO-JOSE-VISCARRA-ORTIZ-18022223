// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Ejercicio_2_progra_1.Entidades;
using Ejercicio_2_progra_1.Negocio;

ClsServidor clsservidor= new ClsServidor();

Servidor servidor= new Servidor();
Console.WriteLine("Ingresa la palabra que desee ");
servidor.cuenta= Console.ReadLine();
Console.WriteLine("El resultado de letra que usted ingreso es "+ servidor.cuenta?.Length);