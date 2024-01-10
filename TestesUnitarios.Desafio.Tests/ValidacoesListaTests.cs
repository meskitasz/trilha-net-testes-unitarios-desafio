using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // Resolvido!!

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert

        Assert.False(resultado);
    }

    // Resolvido!!
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // Resolvido!!

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        var num = 2;
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, num);
        

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Resolvido!!

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = 9;

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        // Resolvido!!
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Resolvido!!

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = -8;


        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        // Resolvido!!
        Assert.Equal(resultadoEsperado, resultado);
    }
}
