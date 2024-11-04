using PlayList.Core.Entidades;
using PlayList.Core.Contratos.Servicos;
using System;

namespace PlayList.Web.Controller
{
    internal class MusicController
    {
        private readonly IMidiaService _midiaService;

        public MusicController(IMidiaService midiaService)
        {
            _midiaService = midiaService;
        }

        public void Criar(string nome, string artista, int duracao)
        {
            var musica = new Musica(nome, artista, duracao);
            _midiaService.Add(musica);
        }

        public void Ler()
        {
            var midias = _midiaService.GetAll();
            foreach (var midia in midias)
            {
                midia.ExibirDetalhes();
            }
        }

        public void Editar(int id, string novoNome)
        {
            _midiaService.Update(id, novoNome);
        }

        public void Delete(int id)
        {
            _midiaService.Delete(id);
        }
    }
}
