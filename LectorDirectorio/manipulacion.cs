
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace LectorDirectorio
{

    public class Manipulacion
    {




        public void readdirectorio(string direccion)
        {

            List<string> ListadoDeCarpetas = Directory.GetDirectories(direccion).ToList();

            List<string> ListadoDeArchivo= Directory.GetFiles(direccion).ToList();

            foreach (string carpeta in ListadoDeCarpetas)
            {
                Console.WriteLine(carpeta);




            }
            foreach (string archivo in ListadoDeArchivo)
            {
                Console.WriteLine(archivo);
                FileInfo infoArchivo = new FileInfo(archivo);
                long archivoKB = infoArchivo.Length / 1024;
                Console.WriteLine("El peso del archivo es :" +archivoKB + " KB");
                
            }

            
        }

    



    }

}