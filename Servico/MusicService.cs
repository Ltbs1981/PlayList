using PlayList.Core.Entidades;
using PlayList.Infra.Repositorios;
namespace PlayList.Servico
{
    internal class MusicService
    {
        private static MusicRepository _musicRepository = new MusicRepository();

        public void Add(Musica musica)
        {
            _musicRepository.Add(musica);
            Console.WriteLine("Parabéns! Musica adicionada a sua Play list");
        }
        public List<Musica> GetAll()
        {
            return _musicRepository.GetAll();
        }
        public void Update(int id, string novoNome)
        {
            var musica = _musicRepository.GetAll().FirstOrDefault(x => x.Id == id);
            musica.Nome = novoNome;
            _musicRepository.Update(musica);
            Console.WriteLine("O nome da música foi atualizada!");
        }
        public void Delete(int id)
        {
            var musica = _musicRepository.GetAll().FirstOrDefault(x =>x.Id == id);
            _musicRepository.Delete(musica);
            Console.WriteLine("Música apagada da sua Play List");
        }
    }
}