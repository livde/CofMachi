using Xunit;

public class AzucareroTests
{
    [Fact]
    public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
    {
        var azucarero = new Azucarero(10);
        var resultado = azucarero.HasAzucar(5);
        Assert.True(resultado);
    }

    [Fact]
    public void DeberiaDevolverFalsoSiNoHaySuficienteAzucar()
    {
        var azucarero = new Azucarero(10);
        var resultado = azucarero.HasAzucar(15);
        Assert.False(resultado);
    }

    [Fact]
    public void DeberiaRestarAzucarAlAzucarero()
    {
        var azucarero = new Azucarero(10);
        azucarero.GiveAzucar(5);
        Assert.Equal(5, azucarero.CantidadAzucar);
    }
}
