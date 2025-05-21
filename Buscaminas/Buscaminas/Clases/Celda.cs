using System.Drawing;

namespace Buscaminas.Clases
{
    internal class Celda
    {
        public bool TieneMina { get; set; }
        public bool EstaDescubierta { get; set; }
        public bool TieneBandera { get; set; }
        public int MinasAlrededor { get; set; }
        public Point Posicion { get; }


        public Celda()
        {

        }

        public Celda(int fila, int columna)
        {
            Posicion = new Point(fila, columna);
            TieneMina = false;
            EstaDescubierta = false;
            TieneBandera = false;
            MinasAlrededor = 0;
        }
    }
}
