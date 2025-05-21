namespace MemoriaDinamica
{
    internal class Unidad
    {
        public Unidad siguiente {  get; set; }
        public Unidad anterior { get; set; }
        public int dato { get; set; }

        public Unidad(Unidad siguiente, Unidad anterior, int dato)
        {
            this.siguiente = siguiente;
            this.anterior = anterior; 
            this.dato = dato;
        }

        public Unidad(int dato)
        {
            this.siguiente = null;
            this.anterior = null;
            this.dato = dato;
        }
    }
}
