using System;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mediaService = new MediaService();
            mediaService.ReceberDados();
            mediaService.CalcularMedia();
            mediaService.DevolverResultado();
           
        }
    }
}
