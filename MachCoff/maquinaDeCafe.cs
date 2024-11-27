public class MaquinaDeCafe
{
    public Cafetera Cafetera { get; set; }
    public Vaso VasoPequeno { get; set; }
    public Vaso VasoMediano { get; set; }
    public Vaso VasoGrande { get; set; }
    public Azucarero Azucarero { get; set; }

    public MaquinaDeCafe()
    {
        Cafetera = new Cafetera(50);
        VasoPequeno = new Vaso(5, 3);  // 3 Oz
        VasoMediano = new Vaso(5, 5);  // 5 Oz
        VasoGrande = new Vaso(5, 7);   // 7 Oz
        Azucarero = new Azucarero(20);
    }

    public string GetVasoDeCafe(Vaso vaso, int cantidadVasos, int cantidadAzucar)
    {
        if (!Cafetera.HasCafe(vaso.Contenido * cantidadVasos))
        {
            return "No hay Cafe";
        }

        if (!vaso.HasVasos(cantidadVasos))
        {
            return "No hay Vasos";
        }

        if (!Azucarero.HasAzucar(cantidadAzucar))
        {
            return "No hay Azucar";
        }

        // Restamos las cantidades de los recursos
        Cafetera.GiveCafe(vaso.Contenido * cantidadVasos);
        vaso.GiveVasos(cantidadVasos);
        Azucarero.GiveAzucar(cantidadAzucar);

        return "Felicitaciones, su café está listo";
    }

    public Vaso GetTipoDeVaso(string tipoVaso)
    {
        return tipoVaso switch
        {
            "pequeno" => VasoPequeno,
            "mediano" => VasoMediano,
            "grande" => VasoGrande,
            _ => null
        };
    }
}
