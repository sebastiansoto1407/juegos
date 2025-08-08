using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Usuario
    {
        public string Nombre { get; set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }
    }
    class Movimiento
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Movimiento()
        {
            PosX = 0;
            PosY = 0;
        }
    }
    class Puntaje
    {
        public int Puntos { get; set; }

        public Puntaje()
        {
            Puntos = 0;
        }
    }
    class Personaje
    {
        public Usuario Usuario { get; set; }
        public Movimiento Movimiento { get; set; }
        public Puntaje Puntaje { get; set; }

        public Personaje(string nombre)
        {
            Usuario = new Usuario(nombre);
            Movimiento = new Movimiento();
            Puntaje = new Puntaje();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al juego, ingrese un nombre de usuario");
            string nombre= Console.ReadLine();

            Console.WriteLine("\nControles: W=arriba, S=abajo, A=izquierda, D=derecha, +=+10 puntos, Q= salir\n");
            bool jugando = true;
            
            //guardado


        }
    }
}
