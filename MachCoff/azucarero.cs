public class Azucarero
{
    public int CantidadAzucar { get; set; }

    public Azucarero(int cantidadAzucar)
    {
        CantidadAzucar = cantidadAzucar;
    }

    public bool HasAzucar(int cantidad)
    {
        return CantidadAzucar >= cantidad;
    }

    public void GiveAzucar(int cantidad)
    {
        CantidadAzucar -= cantidad;
    }
}
