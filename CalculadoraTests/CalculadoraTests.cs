using Calculadora.Services;
namespace CalculadoraTests;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests(){_calc = new CalculadoraImp();}
    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1,num2);
        //Assert
        Assert.Equal(15,resultado);
    }
    [Fact]
    public void DeveVerificarSe4ParEVerdadeiro()
    {
        // Arrange
        int num = 4;
        // Act
        bool resultado = _calc.EhPar(num);
        // Assert
        Assert.True(resultado);
    }

    //Caso 1
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    [InlineData(12)]
    public void VerificarSeOsNUmerosAcimaSaoPares(int numero){
        //Act
        bool resultado = _calc.EhPar(numero);
        //Assert
        Assert.True(resultado);
    }
    //Caso 2
     [Theory]
    [InlineData(new int[]{2,4,6})]
    [InlineData(new int[]{8,10,12})]
    public void Refatorado_VerificarSeOsNUmerosAcimaSaoPares(int[] numeros){
        //Act // Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }
}