using WindowsFormsApp1.Modelos;

public class PilaDificultad
{
    private NodoDificultad cabeza;
    private int contador;

    public PilaDificultad()
    {
        cabeza = null;
        contador = 0;
    }

    public void Push(Dificultad nueva)
    {
        var nodo = new NodoDificultad(nueva);
        nodo.siguiente = cabeza;
        cabeza = nodo;
        contador++;
    }

    public Dificultad Pop()
    {
        if (IsEmpty()) return null;

        var valor = cabeza.Valor;
        cabeza = cabeza.siguiente;
        contador--;
        return valor;
    }

    public Dificultad Peek()
    {
        return cabeza?.Valor;
    }

    public bool IsEmpty()
    {
        return cabeza != null ? false: true;
    }

    public int GetTamanio()
    {
        return contador;
    }

    public void Clear()
    {
        cabeza = null;
        contador = 0;
    }

    public Dificultad[] ObtenerTodo()
    {
        var resultado = new Dificultad[contador];
        var actual = cabeza;
        int i = 0;

        while (actual != null)
        {
            resultado[i++] = actual.Valor;
            actual = actual.siguiente;
        }

        return resultado;
    }
}
