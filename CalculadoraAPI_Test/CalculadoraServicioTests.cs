using CalculadoraAPI.Services;
using Xunit;

namespace CalculadoraAPI_Test
{
    public class CalculadoraServicioTests
    {
        private readonly CalculadoraServicio _calculadora;

        public CalculadoraServicioTests()
        {
            _calculadora = new CalculadoraServicio();
        }

        [Fact]
        public void Sumar_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Sumar(5, 3);
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Sumar_NumerosNegativos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Sumar(-5, -3);
            Assert.Equal(-8, resultado);
        }

        [Fact]
        public void Restar_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Restar(10, 4);
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Restar_NumerosNegativos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Restar(-10, -4);
            Assert.Equal(-6, resultado);
        }

        [Fact]
        public void Multiplicar_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Multiplicar(6, 7);
            Assert.Equal(42, resultado);
        }

        [Fact]
        public void Multiplicar_NumerosNegativos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Multiplicar(-6, -7);
            Assert.Equal(42, resultado);
        }

        [Fact]
        public void Dividir_NumerosPositivos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Dividir(20, 5);
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Dividir_NumerosNegativos_RetornaResultadoCorrecto()
        {
            var resultado = _calculadora.Dividir(-20, -5);
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Dividir_EntreCero_LanzaExcepcion()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(10, 0));
        }
    }
}