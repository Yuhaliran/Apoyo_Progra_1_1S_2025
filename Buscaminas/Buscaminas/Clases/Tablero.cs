using System;

namespace Buscaminas.Clases
{
    internal class Tablero
    {
        public int Filas { get; }
        public int Columnas { get; }
        public int TotalMinas { get; }
        public Celda[,] Celdas { get; }

        public Tablero(int filas, int columnas, int totalMinas)
        {
            Filas = filas;
            Columnas = columnas;
            TotalMinas = totalMinas;
            Celdas = new Celda[filas, columnas];

            InicializarCeldas();
            ColocarMinasAleatoriamente();
            CalcularMinasAlrededor();
        }

        private void InicializarCeldas()
        {
            for (int i = 0; i < Filas; i++)
                for (int j = 0; j < Columnas; j++)
                    Celdas[i, j] = new Celda(i, j);
        }

        private void ColocarMinasAleatoriamente()
        {
            Random rnd = new Random();
            int minasColocadas = 0;

            while (minasColocadas < TotalMinas)
            {
                int fila = rnd.Next(Filas);
                int columna = rnd.Next(Columnas);

                if (!Celdas[fila, columna].TieneMina)
                {
                    Celdas[fila, columna].TieneMina = true;
                    minasColocadas++;
                }
            }
        }

        private void CalcularMinasAlrededor()
        {
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    if (!Celdas[i, j].TieneMina)
                    {
                        Celdas[i, j].MinasAlrededor = ContarMinasAlrededor(i, j);
                    }
                }
            }
        }

        private int ContarMinasAlrededor(int fila, int columna)
        {
            int contador = 0;

            for (int i = fila - 1; i <= fila + 1; i++)
            {
                for (int j = columna - 1; j <= columna + 1; j++)
                {
                    if (i >= 0 && i < Filas && j >= 0 && j < Columnas)
                    {
                        if (Celdas[i, j].TieneMina)
                            contador++;
                    }
                }
            }

            return contador;
        }

    }
}
