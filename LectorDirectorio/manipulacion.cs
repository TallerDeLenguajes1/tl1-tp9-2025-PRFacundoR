
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
            List<string> ListadoDeArchivo = Directory.GetFiles(direccion).ToList();




            foreach (string carpeta in ListadoDeCarpetas)
            {
                Console.WriteLine(carpeta);




            }

            string ruta = "reporte_archivos.csv";
            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "Nombre del Archivo;Tamaño (KB);Fecha de Última Modificación"+ Environment.NewLine);// crea y escrive dentro del archivp

            }

            foreach (string archivo in ListadoDeArchivo)
            {
                Console.WriteLine(archivo);

                FileInfo infoArchivo = new FileInfo(archivo);

                long archivoKB = infoArchivo.Length / 1024;
                Console.WriteLine("El peso del archivo es :" + archivoKB + " KB");


                string nombreArchivo = Path.GetFileName(archivo);
                string fechaModificacion = infoArchivo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss");
                string lineaCSV = $"{nombreArchivo};{archivoKB};{fechaModificacion}";

                File.AppendAllText(ruta, lineaCSV+Environment.NewLine/*sato de linea*/);


            }


        }





    }

}