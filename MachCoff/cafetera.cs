public class Cafetera
{
    public int CantidadCafe { get; set; }

    public Cafetera(int cantidadCafe)
    {
        CantidadCafe = cantidadCafe;
    }

    public bool HasCafe(int cantidad)
    {
        return CantidadCafe >= cantidad;
    }

    public void GiveCafe(int cantidad)
    {
        CantidadCafe -= cantidad;
    }
}
