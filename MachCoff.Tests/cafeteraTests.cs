using Xunit;

public class CafeteraTests
{
    [Fact]
    public void DeberiaDevolverVerdaderoSiExisteCafe()
    {
        var cafetera = new Cafetera(10);
        var resultado = cafetera.HasCafe(5);
        Assert.True(resultado);
    }

    [Fact]
    public void DeberiaDevolverFalsoSiNoExisteCafe()
    {
        var cafetera = new Cafetera(10);
        var resultado = cafetera.HasCafe(11);
        Assert.False(resultado);
    }

    [Fact]
    public void DeberiaRestarCafeALaCafetera()
    {
        var cafetera = new Cafetera(10);
        cafetera.GiveCafe(7);
        Assert.Equal(3, cafetera.CantidadCafe);
    }
}
