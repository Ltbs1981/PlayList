using PlayList.Core.Entidades;
using PlayList.Core.Contratos.Repositorios;
namespace PlayList.Infra.Repositorios
{
    internal class MusicRepository: IMusicRepository
    {
        private static List<Musica> musicas = new List<Musica>();
        private static int id = 0;

        public void Add(Musica musica)
        {
            musica.Id = id++;
            musicas.Add(musica);
        }
        public List<Musica> GetAll()
        {
            return musicas;
        }
        public void Update(Musica musica)
        {
            Musica banco = musicas.FirstOrDefault(i => i.Id == musica.Id);
        }
        public void Delete(Musica musica)
        {
            musicas.Remove(musica);
        }
    }
}