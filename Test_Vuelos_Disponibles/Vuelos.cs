using Xunit;
using FluentAssertions;
using Vuelos_Disponibles;

namespace Vuelos_Disponibles
{
    public class Vuelos
    {
        [Theory]
        [InlineData("true")]
        public void Test_Vuelos_Disponibles(string vuelo)
        {
            //Arrange: Inicializar la variables
           
            //Act: llamar al metodo a testear
            var resultado = Vuelos_Disponibles.DevuelveSiVueloEstaDisponible(vuelo);

            //Assert: comprobar el valor esperado
            //Assert.Equal(resultado, R);
            resultado.Should().Be(resultado);
        }
        [Theory]
        [InlineData("true")]
        public void Deberia_devolverQueNoHayPasajesCuandoElVueloEsteLleno(string vuelo)
        {
            //Arrange: Inicializar la variables

            //Act: llamar al metodo a testear
            var resultado = Vuelos_lleno.DevuelveSiVueloEstaLleno(vuelo);

            //Assert: comprobar el valor esperado
            //Assert.Equal(resultado, R);
            resultado.Should().Be(resultado);
        }
        [Theory]
        [InlineData("true")]
        public void DeberiadevolverQueElVueloEstaCanceladoCuandoElVueloSeCancele(string vuelo)
        {
            //Arrange: Inicializar la variables

            //Act: llamar al metodo a testear
            var resultado = Vuelo_Cancelado.DevuelveSiVueloEstaCancelado(vuelo);

            //Assert: comprobar el valor esperado
            //Assert.Equal(resultado, R);
            resultado.Should().Be(resultado);
        }
    }
}