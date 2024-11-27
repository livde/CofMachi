using Xunit;

public class MaquinaDeCafeTests
{
    private MaquinaDeCafe maquinaDeCafe;
    private Cafetera cafetera;
    private Vaso vasoPequeno;
    private Vaso vasoMediano;
    private Vaso vasoGrande;
    private Azucarero azucarero;

    public MaquinaDeCafeTests()
    {
        cafetera = new Cafetera(50);
        vasoPequeno = new Vaso(5, 3);
        vasoMediano = new Vaso(5, 5);
        vasoGrande = new Vaso(5, 7);
        azucarero = new Azucarero(20);
        maquinaDeCafe = new MaquinaDeCafe();
        maquinaDeCafe.Cafetera = cafetera;
        maquinaDeCafe.VasoPequeno = vasoPequeno;
        maquinaDeCafe.VasoMediano = vasoMediano;
        maquinaDeCafe.VasoGrande = vasoGrande;
        maquinaDeCafe.Azucarero = azucarero;
    }

    [Fact]
    public void DeberiaDevolverUnVasoPequeno()
    {
        var resultado = maquinaDeCafe.GetTipoDeVaso("pequeno");
        Assert.Equal(vasoPequeno, resultado);
    }

    [Fact]
    public void DeberiaDevolverCafeListoSiHayVasosYCafe()
    {
        var resultado = maquinaDeCafe.GetVasoDeCafe(vasoPequeno, 1, 5);
        Assert.Equal("Felicitaciones, su café está listo", resultado);
    }

    [Fact]
    public void DeberiaDevolverMensajeSiNoHayCafe()
    {
        cafetera.GiveCafe(50); // Agotamos todo el café
        var resultado = maquinaDeCafe.GetVasoDeCafe(vasoPequeno, 1, 5);
        Assert.Equal("No hay Cafe", resultado);
    }
}
