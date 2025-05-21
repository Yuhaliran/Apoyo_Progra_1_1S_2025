namespace MemoriaDinamica.Clases
{
    internal class Pila
    {
        private Unidad cabeza;
        private int contador;

        public Pila()
        {
            this.cabeza = null;
            contador = 0;
        }

        public Pila(Unidad insertando)
        {
            this.cabeza = insertando;
            contador = 1;
        }

        public int GetTamanio()
        {
            return contador;
        }

        public void Push(Unidad insertando)
        {
            if (cabeza == null)
            {
                cabeza = insertando;
            }
            else
            {
                insertando.anterior = cabeza;
                cabeza.siguiente = insertando;

                cabeza = insertando;
            }

            contador++;
        }

        public Unidad Pop()
        {
            if (cabeza == null)
            {
                return null;
            }
            else
            {
                Unidad auxilair = cabeza;
                cabeza = cabeza.anterior;  

                if (cabeza != null)
                {
                    cabeza.siguiente = null; 
                }
                auxilair.anterior = null;

                contador--;

                return auxilair;
            }
        }


        public Unidad[] ObtenerTodos()
        {
            Unidad auxiliar = cabeza;
            int cantidad = 0;

            while (auxiliar != null)
            {
                cantidad++;
                auxiliar = auxiliar.anterior;
            }

            Unidad[] unidades = new Unidad[cantidad];

            auxiliar = cabeza;
            int i = 0;
            while (auxiliar != null)
            {
                unidades[i] = auxiliar;
                auxiliar = auxiliar.anterior;
                i++;
            }

            return unidades;
        }

    }
}
