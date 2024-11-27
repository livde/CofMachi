using Xunit;

public class VasoTests
{
    [Fact]
    public void DeberiaDevolverVerdaderoSiExistenVasos()
    {
        var vaso = new Vaso(2, 10);
        var resultado = vaso.HasVasos(1);
        Assert.True(resultado);
    }

    [Fact]
    public void DeberiaDevolverFalsoSiNoExistenVasos()
    {
        var vaso = new Vaso(1, 10);
        var resultado = vaso.HasVasos(2);
        Assert.False(resultado);
    }

    [Fact]
    public void DeberiaRestarCantidadDeVaso()
    {
        var vaso = new Vaso(5, 10);
        vaso.GiveVasos(1);
        Assert.Equal(4, vaso.CantidadVasos);
    }
}
