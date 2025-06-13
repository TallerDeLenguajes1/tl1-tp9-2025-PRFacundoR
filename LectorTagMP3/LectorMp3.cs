using System.Reflection.Metadata;

namespace LectorTagMP3
{
     public class LectorMp3
    {


        //no tiene cmapos ni propiedades, ni constructor, solo un metodo


        public void ReadTagMp3(string rutaMp3)
        {

            byte[] buffer = new byte[128];


            FileStream Mp3 = new FileStream(rutaMp3, FileMode.Open);

            Mp3.Read(buffer, 0, 128);
           string header = System.Text.Encoding.Default.GetString(buffer, 0, 3);

            string titulo = System.Text.Encoding.Default.GetString(buffer, 3, 30).TrimEnd('\0', ' ');
            string artista = System.Text.Encoding.Default.GetString(buffer, 33, 30).TrimEnd('\0', ' ');
            string album = System.Text.Encoding.Default.GetString(buffer, 63, 30).TrimEnd('\0', ' ');
            string anio = System.Text.Encoding.Default.GetString(buffer, 93, 4).TrimEnd('\0', ' ');
            string comentario = System.Text.Encoding.Default.GetString(buffer, 97, 30).TrimEnd('\0', ' ');

            byte generoCodigo = buffer[127];


            
            Console.WriteLine($"Header: {header}");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Artista: {artista}");
            Console.WriteLine($"Álbum: {album}");
            Console.WriteLine($"Año: {anio}");
            Console.WriteLine($"Comentario: {comentario}");
            Console.WriteLine($"Género código: {generoCodigo}");


        }

    }
}