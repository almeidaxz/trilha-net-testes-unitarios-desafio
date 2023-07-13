using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var palavra = "Matrix";
        var resultadoEsperado = 6;

        // Act
        var quantidadeCaracteres = _validacoes.RetornarQuantidadeCaracteres(palavra);

        // Assert
        Assert.Equal(resultadoEsperado, quantidadeCaracteres);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var palavraProcurada = "qualquer";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
         var contemPalavra = _validacoes.ContemCaractere(texto, palavraProcurada);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(contemPalavra);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var contemPalavra = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(contemPalavra);
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var terminaComAPalavra = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(terminaComAPalavra);
    }
}
