using System.Collections.Generic;

namespace MemoriaDinamica
{
    internal class Cola
    {
        private Unidad cabeza;
        private Unidad cola;
        private int contador;

        public Cola()
        {
            this.cabeza = null;
            this.cola = null;
            contador = 0;
        }

        public Cola(Unidad insertando)
        {
            this.cabeza=insertando;
            this.cola = insertando;
            contador = 1;
        }

        public void Push(Unidad insertando)
        {
            if (cabeza == null)
            {
                cabeza = insertando;
                cola = insertando;
            }
            else
            {
                cola.siguiente = insertando;
                insertando.anterior = cola;

                cola = insertando;
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
                Unidad auxiliar = cabeza;
                cabeza = cabeza.siguiente;

                if (cabeza != null)
                {
                    cabeza.anterior = null;
                }
                else
                {
                    cola = null;
                }

                auxiliar.siguiente = null;

                contador--;
                return auxiliar;
            }
        }

        public Unidad[] ObtenerTodo()
        {
            List<Unidad> unidades = new List<Unidad>();

            Unidad auxilar = cabeza;

            while (auxilar != null)
            {
                unidades.Add(auxilar);
                auxilar = auxilar.siguiente;
            }

            return unidades.ToArray();
        }

        public int GetTamanio()
        {
            return contador;
        }
    }
}
