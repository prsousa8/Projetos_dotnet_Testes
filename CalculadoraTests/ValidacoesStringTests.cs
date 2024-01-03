using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString validacoes;

        public ValidacoesStringTests(){
            validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresERetornar3(){
            //Arrange
            string texto = "Ola";
            //Act
            int resultado = validacoes.ContarCaracteres(texto);
            //Assert
            Assert.Equal(3,resultado);
        }
    }
}