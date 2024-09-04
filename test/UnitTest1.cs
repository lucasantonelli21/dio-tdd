using System;
using Xunit;
using src;



namespace test;

public class UnitTest1
{
    public Calculadora criarCalculadora(){
        return new Calculadora();
    }
    [Theory]
    [InlineData (1,2,3)]
    public void TesteSomar(int valor1, int valor2, int resultado)
    {
        var calculadora = criarCalculadora();
        int resultadoCalculadora = calculadora.somar(valor1, valor2);
        Assert.Equal (resultado,resultadoCalculadora);
    }
    
    [Theory]
    [InlineData (2,1,1)]
    public void TesteSubtrair(int valor1, int valor2, int resultado)
    {
        var calculadora = criarCalculadora();
        int resultadoCalculadora = calculadora.subtrair(valor1, valor2);
        Assert.Equal (resultado,resultadoCalculadora);
    }

    [Theory]
    [InlineData (2,3,6)]
    public void TesteMultiplicar(int valor1, int valor2, int resultado)
    {
        var calculadora = criarCalculadora();
        int resultadoCalculadora = calculadora.multiplicar(valor1, valor2);
        Assert.Equal (resultado,resultadoCalculadora);
    }
    [Theory]
    [InlineData (6,3,2)]
    public void TesteDividir(int valor1, int valor2, int resultado)
    {
        var calculadora = criarCalculadora();
        int resultadoCalculadora = calculadora.dividir(valor1, valor2);
        Assert.Equal (resultado,resultadoCalculadora);
    }

    [Fact]
    public void TesteDividizaoPorZero()
    {
        var calculadora = criarCalculadora();
        Assert.Throws<DivideByZeroException>(
                () => calculadora.dividir(3,0)
            );
    }
    [Fact]
    public void TesteHistorico()
    {
        var calculadora = criarCalculadora();
        calculadora.somar(1,2);
        calculadora.somar(3,4);
        var lista = calculadora.listarHistorico();
        Assert.NotEmpty(lista);
        Assert.Equal(2,lista.Count);
    }
}