using PlayList.Core.Entidades;
using PlayList.Core.Contratos.Servicos;
using System;

namespace PlayList.Web.Controller
{
    internal class MusicController
    {
        private readonly IMusicService _musicService;

        //colocando a responsabilidade para o construtor
        public MusicController(IMusicService musicService)
        {
            _musicService = musicService;
        }

        public void Criar(string nome, string artista, int duracao)
        {
            Musica musica = new Musica(nome, artista, duracao);
            _musicService.Add(musica);
        }

        public void Ler()
        {
            var musicas = _musicService.GetAll();
            foreach (var musica in musicas)
            {
                Console.WriteLine($"{musica.Id} - {musica.Nome} - {musica.Artista} - {musica.Duracao} min");
            }
        }

        public void Editar(int id, string novoNome)
        {
            _musicService.Update(id, novoNome);
        }

        public void Delete(int id)
        {
            _musicService.Delete(id);
        }
    }
}
