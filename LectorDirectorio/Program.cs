
// See https://aka.ms/new-console-template for more information
using LectorDirectorio;


string direccion;

Manipulacion archivo = new Manipulacion();


do
{
    Console.WriteLine("Ingrese la direccion del archivo");
    direccion = Console.ReadLine();

    if (Directory.Exists(direccion))
    {
        archivo.readdirectorio(direccion);


    }
    else
    {
        Console.WriteLine("Ingrese una direccion correcta");
    }



} while (!Directory.Exists(direccion));

