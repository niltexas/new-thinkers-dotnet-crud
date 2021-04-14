using Bogus;
using JogoCrud.DTO.AdicionarJogo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCrud.Teste.Builder
{
    public class AdicionarJogoRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarJogoRequest _adicionarJogo;

        public AdicionarJogoRequestBuilder()
        {
            _adicionarJogo = new AdicionarJogoRequest();
            _adicionarJogo.nome = _faker.Random.String(40);

        }
        public AdicionarJogoRequestBuilder withNameLength(int tamanho)
        {
            _adicionarJogo.nome = _faker.Random.String(40);
            return this;
        }
        public AdicionarJogoRequest Build()
        {
            return _adicionarJogo;
        }
    }
}
