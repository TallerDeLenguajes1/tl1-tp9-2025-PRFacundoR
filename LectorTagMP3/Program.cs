// See https://aka.ms/new-console-template for more information
using LectorTagMP3;

Console.WriteLine("Ingrese el archivo mp3");
string rutaMp3 = Console.ReadLine();

LectorMp3 lector = new LectorMp3();

lector.ReadTagMp3(rutaMp3);