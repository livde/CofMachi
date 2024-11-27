public class Vaso
{
    public int CantidadVasos { get; set; }
    public int Contenido { get; set; }

    public Vaso(int cantidadVasos, int contenido)
    {
        CantidadVasos = cantidadVasos;
        Contenido = contenido;
    }

    public bool HasVasos(int cantidad)
    {
        return CantidadVasos >= cantidad;
    }

    public void GiveVasos(int cantidad)
    {
        CantidadVasos -= cantidad;
    }
}
