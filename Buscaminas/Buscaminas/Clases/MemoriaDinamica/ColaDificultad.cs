using System.Collections.Generic;
using WindowsFormsApp1.Modelos;

public class ColaDificultad
{
    private NodoDificultad cabeza;
    private NodoDificultad cola;
    private int contador;

    public ColaDificultad()
    {
        cabeza = null;
        cola = null;
        contador = 0;
    }

    public ColaDificultad(Dificultad insertando)
    {
        var nodo = new NodoDificultad(insertando);
        cabeza = nodo;
        cola = nodo;
        contador = 1;
    }

    public void Push(Dificultad insertando)
    {
        var nuevoNodo = new NodoDificultad(insertando);

        if (cabeza == null)
        {
            cabeza = cola = nuevoNodo;
        }
        else
        {
            cola.siguiente = nuevoNodo;
            nuevoNodo.anterior = cola;
            cola = nuevoNodo;
        }

        contador++;
    }

    public Dificultad Pop()
    {
        if (cabeza == null)
            return null;

        var valor = cabeza.Valor;
        cabeza = cabeza.siguiente;

        if (cabeza != null)
            cabeza.anterior = null;
        else
            cola = null;

        contador--;
        return valor;
    }

    public Dificultad Peek()
    {
        if (cabeza != null)
        {
            return cabeza.Valor;
        }
        else
        {
            return null;
        }
    }

    public bool IsEmpty()
    {
        return cabeza == null? true: false;  
    }

    public NodoDificultad GetCabeza()
    {
        if (cabeza != null)
        {
            return cabeza;
        }
        else
        {
            return null;
        }
    }


    public Dificultad[] ObtenerTodo()
    {
        List<Dificultad> lista = new List<Dificultad>();
        var actual = cabeza;

        while (actual != null)
        {
            lista.Add(actual.Valor);
            actual = actual.siguiente;
        }

        return lista.ToArray();
    }

    public int GetTamanio()
    {
        return contador;
    }

    public void Limpiar()
    {
        cabeza = cola = null;
        contador = 0;
    }
}
