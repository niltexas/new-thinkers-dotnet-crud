using JogoCrud.Bordas.Adapter;
using JogoCrud.DTO.AdicionarJogo;
using JogoCrud.Repositorios;
using JogoCrud.UseCase;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DotNetCrud.Entities;
using FluentAssertions;
using DotNetCrud.Teste.Builder;

namespace DotNetCrud.Teste
{
    public class AdicionarJogoUseCaseTeste
    {

        private readonly Mock<IRepositorioJogo> _repositorioJogo;
        private readonly Mock<IAdicionarJogoAdapter> _adicionarJogoAdapter;
        private readonly AdicionarJogoUseCase _usecase;

        public AdicionarJogoUseCaseTeste()
        {
            _repositorioJogo = new Mock<IRepositorioJogo>();
            _adicionarJogoAdapter = new Mock<IAdicionarJogoAdapter>();
            _usecase = new AdicionarJogoUseCase(_repositorioJogo.Object, _adicionarJogoAdapter.Object);
        }

        [Fact]
        public void Jogo_AdicionarJogo_QuandoRetornarSucesso()
        {

            //Arrange (variáveis)
            var request = new AdicionarJogoRequestBuilder().Build();
            var response = new AdicionarJogoResponse();
            var jogo = new Jogo();
            jogo.id = 1;

            response.msg = "Adicionado com sucesso";
            response.id = 1;
            

            _repositorioJogo.Setup(repositorio => repositorio.Add(jogo)).Returns(jogo.id);
            _adicionarJogoAdapter.Setup(adapter => adapter.convertRequestParaJogo(request)).Returns(jogo);


            //Act (chamar funções)
            var resultado = _usecase.Executar(request);

            //Assert (regras dos testes que serão utilizados)
            response.Should().BeEquivalentTo(resultado);



        }

        [Fact]
        public void Jogo_AdicionarJogo_QuandoNomeMenorQue20()
        {

            var request = new AdicionarJogoRequestBuilder().withNameLength(8).Build();
            var response = new AdicionarJogoResponse();
            

            response.msg = "Erro ao adicionar o jogo";




            /*_repositorioJogo.Setup(repositorio => repositorio.Add(jogo)).Returns(jogo.id);
            _adicionarJogoAdapter.Setup(adapter => adapter.convertRequestParaJogo(request)).Returns(jogo);*/


            //Act (chamar funções)
            var resultado = _usecase.Executar(request);

            //Assert (regras dos testes que serão utilizados)
            response.Should().BeEquivalentTo(resultado);


        }

        [Fact]
        public void Jogo_AdicionarJogo_QuandoRepositorioExcecao()
        {

            //Arrange (variáveis)
            var request = new AdicionarJogoRequestBuilder().Build();
            var response = new AdicionarJogoResponse();
            var jogo = new Jogo();
            jogo.id = 1;

            response.msg = "Erro ao adicionar o jogo";
         


            _repositorioJogo.Setup(repositorio => repositorio.Add(jogo)).Returns(jogo.id);
            _adicionarJogoAdapter.Setup(adapter => adapter.convertRequestParaJogo(request)).Throws(new Exception());


            //Act (chamar funções)
            var resultado = _usecase.Executar(request);

            //Assert (regras dos testes que serão utilizados)
            response.Should().BeEquivalentTo(resultado);

        }


    }
}
