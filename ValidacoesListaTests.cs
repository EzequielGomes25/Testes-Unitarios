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
        //TODO: Implementar método de teste

        // Arrange
        var validacoesLista = new ValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = validacoesLista.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado); 

    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste
       // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

            // Act
            var resultado = validacoesLista.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.True(resultado.SequenceEqual(resultadoEsperado));
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
            var validacoesLista = new ValidacoesLista();
            var lista = new List<int> { 5, -1, -8, 7, 9 };

         // Act
            var maiorNumero = validacoesLista.RetornarMaiorNumeroLista(lista);

        // Assert
            Assert.Equal(9, maiorNumero);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var validacoesLista = new ValidacoesLista();
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var menorNumero = validacoesLista.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, menorNumero);
    }
}
