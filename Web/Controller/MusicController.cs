using PlayList.Core.Entidades;
using PlayList.Servico;
namespace PlayList.Web.Controller
{
    internal class MusicController
           {
        private MusicService _musicService;

        public MusicController()
        {
            _musicService = new MusicService();
        }
        public void Criar(string nome, string artista, int duracao) 
        {
            Musica musica = new Musica()
            {
                Nome = nome,
                Artista = artista,
                Duracao = duracao
            };
            _musicService = new MusicService();
            _musicService.Add(musica);
        }
        public void Ler()
        {
            var musicas = _musicService.GetAll();
            foreach (var musica in musicas)
            {
                Console.WriteLine($"{musica.Id}{musica.Nome}{musica.Artista}{musica.Duracao}");
            }
        }
        public void Editar(int id, string novoNome)
        {
            _musicService = new MusicService();
            _musicService.Update(id, novoNome);
        }
        public void Delete(int id)
        {
            _musicService = new MusicService();
            _musicService.Delete(id);
        }
    }
}
