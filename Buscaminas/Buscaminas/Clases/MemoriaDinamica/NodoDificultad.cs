using WindowsFormsApp1.Modelos;

public class NodoDificultad
{
    public Dificultad Valor { get; set; }
    public NodoDificultad siguiente { get; set; }
    public NodoDificultad anterior { get; set; }

    public NodoDificultad(Dificultad valor)
    {
        Valor = valor;
        siguiente = null;
        anterior = null;
    }
}
